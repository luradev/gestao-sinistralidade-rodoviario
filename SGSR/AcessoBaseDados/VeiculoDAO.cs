using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class VeiculoDAO
    {
        SqlCeConnection ligacao;

        public VeiculoDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Veiculo veiculo)
        {
            string sql = "INSERT INTO tb_veiculo(matricula, lotacao, id_modelo_veiculo, id_tipo_veiculo) VALUES(@matricula, @lotacao, @id_modelo_veiculo, @id_tipo_veiculo)";
            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("matricula", veiculo.Matricula);
                comando.Parameters.AddWithValue("lotacao", veiculo.Lotacao);
                comando.Parameters.AddWithValue("id_modelo_veiculo", veiculo.ModeloVeiculo.IdModelo);
                comando.Parameters.AddWithValue("id_tipo_veiculo", veiculo.Tipo.Idtipo);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public void editar(Veiculo veiculo)
        {
            string sql = "UPDATE tb_veiculo SET matricula = @matricula, lotacao = @lotacao, "
            + "id_modelo_veiculo = @id_modelo_veiculo, id_tipo_veiculo = @id_tipo_veiculo "
            + "WHERE id_veiculo = @id_veiculo";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("matricula", veiculo.Matricula);
                comando.Parameters.AddWithValue("lotacao", veiculo.Lotacao);
                comando.Parameters.AddWithValue("id_modelo_veiculo", veiculo.ModeloVeiculo.IdModelo);
                comando.Parameters.AddWithValue("id_tipo_veiculo", veiculo.Tipo.Idtipo);
                comando.Parameters.AddWithValue("id_veiculo", veiculo.IdVeiculo);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM tb_veiculo WHERE id_veiculo = @id";
            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public List<Veiculo> getAll()
        {
            string sql = "SELECT id_veiculo, matricula, lotacao, m.nome as modelo, t.nome as tipo FROM tb_veiculo v INNER JOIN tb_modelo_veiculo m ON v.id_modelo_veiculo = m.id_modelo_veiculo INNER JOIN tb_tipo_veiculo t ON t.id_tipo_veiculo = v.id_tipo_veiculo";                        
            List<Veiculo> lista = new List<Veiculo>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Veiculo veiculo = new Veiculo();
                    if (!Convert.IsDBNull(rs["id_veiculo"]))
                        veiculo.IdVeiculo = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["matricula"]))
                        veiculo.Matricula = rs.GetString(1);
                    if (!Convert.IsDBNull(rs["lotacao"]))
                        veiculo.Lotacao = rs.GetInt32(2);

                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["modelo"]))
                        modelo.Nome = rs.GetString(3);

                    TipoVeiculo tipo = new TipoVeiculo();
                    if (!Convert.IsDBNull(rs["tipo"]))
                        tipo.Nome = rs.GetString(4);

                    veiculo.ModeloVeiculo = modelo;
                    veiculo.Tipo = tipo;

                    lista.Add(veiculo);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }

        public List<string> getAllConcatenado()
        {
            string sql = "select v.id_veiculo as id, ma.nome +' '+ mo.nome +' - '+ v.matricula as veiculo "
                + "from tb_veiculo v inner join tb_modelo_veiculo mo "
                + "on v.id_modelo_veiculo = mo.id_modelo_veiculo inner join tb_marca_veiculo ma "
                + "on mo.id_marca_veiculo = ma.id_marca_veiculo order by id asc";

            List<string> lista = new List<string>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    String aux = null;
                    if (!Convert.IsDBNull(rs["id"]))
                        aux = rs.GetInt32(0).ToString();
                    if(!Convert.IsDBNull(rs["veiculo"]))
                        aux += "- " + rs.GetString(1).ToString();

                    lista.Add(aux);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }

        
         
    }
}
