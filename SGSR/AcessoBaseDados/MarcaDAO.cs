using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class MarcaDAO
    {
        SqlCeConnection ligacao;

        public MarcaDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Marca marca)
        {
            string sql = "INSERT INTO tb_marca_veiculo(nome) VALUES(@nome)";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", marca.Nome);                
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public void editar(Marca marca)
        {
            string sql = "UPDATE tb_marca_veiculo SET nome = @nome "
            + "WHERE id_marca_veiculo = @marca";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", marca.Nome);
                comando.Parameters.AddWithValue("marca", marca.Idmarca);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception) { }

        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM tb_marca_veiculo WHERE id_marca_veiculo = @id";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception) { }
        }

        public List<Marca> getAll()            
        {
            string sql = "SELECT id_marca_veiculo, nome FROM tb_marca_veiculo";           
            List<Marca> lista = new List<Marca>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Marca marca = new Marca();
                    if (!Convert.IsDBNull(rs["id_marca_veiculo"]))
                        marca.Idmarca = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        marca.Nome = rs.GetString(1);

                    lista.Add(marca);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }

        public Marca getMarcaByID(int id)
        {
            string sql = "SELECT id_marca_veiculo, nome FROM tb_marca_veiculo WHERE id_marca_veiculo = @id";
            Marca marca = new Marca();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["id_marca_veiculo"]))
                        marca.Idmarca = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        marca.Nome = rs.GetString(1);
                }
                ligacao.Close();
            }
            catch (Exception) { }

            return marca;
        }
    }
}
