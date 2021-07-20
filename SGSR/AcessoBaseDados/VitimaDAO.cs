using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class VitimaDAO
    {
        SqlCeConnection ligacao;

        public VitimaDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Vitima vitima)
        {
            string sql = "INSERT INTO tb_vitima(nome,categoria,descricao,id_acidente) VALUES(@nome,@categoria,@descricao,@id_acidente)";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", vitima.Nome);
                comando.Parameters.AddWithValue("categoria", vitima.Categoria);
                comando.Parameters.AddWithValue("descricao", vitima.Descricao);
                comando.Parameters.AddWithValue("id_acidente", vitima.Acidente.IdAcidente);
                //Console.WriteLine("IDD: " + vitima.Acidente.IdAcidente);
                comando.ExecuteNonQuery();

                ligacao.Close();                
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public List<Vitima> getByAcidente(int idAcidente)
        {
            string sql = "SELECT id_vitima, nome, categoria, descricao, id_acidente "
                        + "FROM tb_vitima where id_acidente = @id";
            List<Vitima> lista = new List<Vitima>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", idAcidente);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Vitima vitima = new Vitima();

                    if (!Convert.IsDBNull(rs["id_vitima"]))
                        vitima.IdVitima = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        vitima.Nome = rs.GetString(1);
                    if (!Convert.IsDBNull(rs["categoria"]))
                        vitima.Categoria = rs.GetString(2);
                    if (!Convert.IsDBNull(rs["descricao"]))
                        vitima.Descricao = rs.GetString(3);

                    Acidente acidente = new Acidente();
                    if (!Convert.IsDBNull(rs["id_acidente"]))
                        acidente.IdAcidente = rs.GetInt32(4);

                    vitima.Acidente = acidente;
                    lista.Add(vitima);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); } //throw new Exception();
            return lista;
        }
    }
}
