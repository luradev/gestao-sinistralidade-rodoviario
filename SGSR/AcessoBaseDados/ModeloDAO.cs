using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class ModeloDAO
    {
        SqlCeConnection ligacao;

        public ModeloDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Modelo modelo)
        {
            string sql = "INSERT INTO tb_modelo_veiculo(nome,id_marca_veiculo) VALUES(@nome,@id_marca)";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", modelo.Nome);
                comando.Parameters.AddWithValue("id_marca", modelo.Marca.Idmarca);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public void editar(Modelo modelo)
        {
            string sql = "UPDATE tb_modelo_veiculo SET nome = @nome, id_marca_veiculo = @marca " 
            + "WHERE id_modelo_veiculo = @modelo";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", modelo.Nome);
                comando.Parameters.AddWithValue("marca", modelo.Marca.Idmarca);
                comando.Parameters.AddWithValue("modelo", modelo.IdModelo);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
 
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM tb_modelo_veiculo WHERE id_modelo_veiculo = @id";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception) { }
        }

        public List<Modelo> getAll()
        {
            string sql = "SELECT mo.id_modelo_veiculo AS id, mo.nome AS modelo, ma.nome AS marca "
                + "FROM tb_modelo_veiculo mo "
                + "INNER JOIN tb_marca_veiculo ma ON mo.id_marca_veiculo = ma.id_marca_veiculo";

            List<Modelo> lista = new List<Modelo>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["id"]))
                        modelo.IdModelo = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["modelo"]))
                        modelo.Nome = rs.GetString(1);

                    Marca marca = new Marca();
                    if (!Convert.IsDBNull(rs["marca"]))
                        marca.Nome = rs.GetString(2);

                    modelo.Marca = marca;

                    lista.Add(modelo);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }

        public List<Modelo> getModeloByMarca(int marca)
        {
            string sql = "SELECT id_modelo_veiculo, nome, id_marca_veiculo FROM tb_modelo_veiculo WHERE id_marca_veiculo = @marca";
            List<Modelo> lista = new List<Modelo>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("marca", marca);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["id_modelo_veiculo"]))
                        modelo.IdModelo = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        modelo.Nome = rs.GetString(1);

                    Marca m = new Marca();
                    if (!Convert.IsDBNull(rs["id_marca_veiculo"]))
                        m.Idmarca = rs.GetInt32(2);

                    modelo.Marca = m;
                    lista.Add(modelo);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }

        public Modelo getModeloByID(int id)
        {
            string sql = "SELECT id_modelo_veiculo, nome, id_marca_veiculo FROM tb_modelo_veiculo " 
            + "WHERE id_modelo_veiculo = @id";

            Modelo modelo = null;

            SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
            comando.Parameters.AddWithValue("id", id);
            SqlCeDataReader rs = comando.ExecuteReader();

            if (rs.Read())
            {
                modelo = new Modelo();
                if (!Convert.IsDBNull(rs["id_modelo_veiculo"]))
                    modelo.IdModelo = rs.GetInt32(0);
                if (!Convert.IsDBNull(rs["nome"]))
                    modelo.Nome = rs.GetString(1);

                Marca marca = new Marca();
                if (!Convert.IsDBNull(rs["id_marca_veiculo"]))
                    marca.Idmarca = rs.GetInt32(2);

                modelo.Marca = marca;
            }

            return modelo;

        }


    }
}
