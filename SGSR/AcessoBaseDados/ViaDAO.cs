using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class ViaDAO
    {
        SqlCeConnection ligacao;

        public ViaDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Via via)
        {
            string sql = "INSERT INTO tb_via(nome,descricao,id_municipio) VALUES(@nome,@descricao,@id_municipio)";            

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", via.Nome);
                comando.Parameters.AddWithValue("descricao", via.Descricao);
                comando.Parameters.AddWithValue("id_municipio", via.Municipio.IdMunicipio);

                comando.ExecuteNonQuery();
                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

        }
                                
        public List<Via> getAll()
        {
            string sql = "SELECT id_via, nome, descricao, m.nome AS muni FROM tb_via v INNER JOIN tb_municipio m ON v.id_municipio = m.id_municipio";
            List<Via> lista = new List<Via>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Via via = new Via();

                    if (!Convert.IsDBNull(rs["id_via"]))
                        via.IdVia = Convert.ToInt32(rs.GetInt32(0));
                    if (!Convert.IsDBNull(rs["nome"]))
                        via.Nome = rs.GetString(1);
                    if (!Convert.IsDBNull(rs["descricao"]))
                        via.Descricao = rs.GetString(2);

                    Municipio municipio = new Municipio();
                    if (!Convert.IsDBNull(rs["muni"]))
                        municipio.IdMunicipio = Convert.ToInt32(rs.GetInt32(3));

                    via.Municipio = municipio;

                    lista.Add(via);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;

        }

        public List<Via> getViaByMunicipio(int id)
        {
            string sql = "select id_via, nome, descricao, id_municipio from tb_via where id_municipio = @id_municipio";
            List<Via> lista = new List<Via>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id_municipio", id);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Via via = new Via();

                    if (!Convert.IsDBNull(rs["id_via"]))
                        via.IdVia = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        via.Nome = rs.GetString(1);
                    if (!Convert.IsDBNull(rs["descricao"]))
                        via.Descricao = rs.GetString(2);

                    Municipio municipio = new Municipio();

                    if (!Convert.IsDBNull(rs["id_municipio"]))
                        municipio.IdMunicipio = rs.GetInt32(3);

                    via.Municipio = municipio;

                    lista.Add(via);
                }
                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }
    }
}
