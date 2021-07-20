using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectosModelos;
using System.Data.SqlServerCe;

namespace AcessoBaseDados
{
    public class ProvinciaDAO
    {
        SqlCeConnection ligacao;

        public ProvinciaDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }


        public void inserir(Provincia provincia)
        {
            string sql = "INSERT INTO tb_provincia(id_provincia,nome) VALUES(@nome)";

            try
            {

                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id_provincia", provincia.IdProvincia);
                comando.Parameters.AddWithValue("nome", provincia.Nome);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public List<Provincia> getAll()
        {
            string sql = "SELECT id_provincia, nome FROM tb_provincia";
            List<Provincia> lista = new List<Provincia>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Provincia provincia = new Provincia();

                    if (!Convert.IsDBNull(rs["id_provincia"]))
                        provincia.IdProvincia = Convert.ToInt32(rs.GetInt32(0));
                    if (!Convert.IsDBNull(rs["nome"]))
                        provincia.Nome = rs.GetString(1);

                    lista.Add(provincia);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }
        
    }
}
