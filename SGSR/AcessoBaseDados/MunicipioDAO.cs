using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectosModelos;
using System.Data.SqlServerCe;

namespace AcessoBaseDados
{
    public class MunicipioDAO
    {
        SqlCeConnection ligacao;

        public MunicipioDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Municipio municipio)
        {
            string sql = "INSERT INTO tb_municipio(id_municipio,nome,id_provincia) VALUES(@id,nome,id_provincia)";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", municipio.IdMunicipio);
                comando.Parameters.AddWithValue("nome", municipio.Nome);
                comando.Parameters.AddWithValue("id_provincia", municipio.Provincia.IdProvincia);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public List<Municipio> getMunicipioByProvincia(int id)
        {
            string sql = "SELECT id_municipio, nome, id_provincia FROM tb_municipio WHERE id_provincia = @id";
            List<Municipio> lista = new List<Municipio>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Municipio municipio = new Municipio();

                    if (!Convert.IsDBNull(rs["id_municipio"]))
                        municipio.IdMunicipio = Convert.ToInt32(rs.GetInt32(0));
                    if (!Convert.IsDBNull(rs["nome"]))
                        municipio.Nome = rs.GetString(1);

                    Provincia provincia = new Provincia();
                    if (!Convert.IsDBNull(rs["id_provincia"]))
                        provincia.IdProvincia = Convert.ToInt32(rs.GetInt32(2));

                    municipio.Provincia = provincia;

                    lista.Add(municipio);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }
    }
}
