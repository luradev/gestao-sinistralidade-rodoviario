using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class DashboardDAO
    {
        SqlCeConnection ligacao;

        public DashboardDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public int getTotalAcidente()
        {
            int total = 0;
            string sql = "SELECT COUNT(id_acidente) AS total FROM tb_acidente";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["total"]))
                        total = rs.GetInt32(0);
                }

                //ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return total;
        }

        public int getTotalVeiculo()
        {
            int total = 0;
            string sql = "SELECT COUNT(id_veiculo) AS total FROM tb_veiculo";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["total"]))
                        total = rs.GetInt32(0);
                }

                //ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return total;
        }

        public int getTotalCondutor()
        {
            int total = 0;
            string sql = "SELECT COUNT(id_condutor) AS total FROM tb_condutor";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["total"]))
                        total = rs.GetInt32(0);
                }

                //ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return total;
        }

        public void getMostSinistrados(Dashboard dash)
        {
            string sql = "SELECT TOP 3 m.nome AS municipio, COUNT(a.id_via) AS QtdAcidente FROM tb_acidente a "
                + "INNER JOIN tb_via v ON a.id_via = v.id_via INNER JOIN tb_municipio m "
                + "ON v.id_municipio = m.id_municipio GROUP BY m.nome ORDER BY QtdAcidente ASC";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["municipio"]))
                        dash.Municipio.Add(rs.GetString(0));
                    if (!Convert.IsDBNull(rs["QtdAcidente"]))
                        dash.QtdAcidente.Add(rs.GetInt32(1));
                }

                //ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }


        public void getAcidentesByClasses(Dashboard dash)
        {
            string sql = "select c.designacao as classe, count(a.id_classificacao_acidente) as QtdAcidente "
                + "from tb_acidente a inner join tb_classificacao_acidente c "
                + "on a.id_classificacao_acidente = c.id_classificacao_acidente group by c.designacao "
                + "order by QtdAcidente desc";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["classe"]))
                        dash.Classificacao.Add(rs.GetString(0));
                    if (!Convert.IsDBNull(rs["QtdAcidente"]))
                        dash.C_QtdAcidente.Add(rs.GetInt32(1));
                }

                //ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public void getViasMaisSinistradas(Dashboard dash)
        {
            string sql = "select top 2 v.nome as via, count(a.id_via) as QtdAcidente "
                + "from tb_acidente a inner join tb_via v on a.id_via = v.id_via "
                + "inner join tb_municipio m on v.id_municipio = m.id_municipio "
                + "group by v.nome order by QtdAcidente desc ";

            SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["via"]))
                        dash.Vias.Add(rs.GetString(0));
                    if (!Convert.IsDBNull(rs["QtdAcidente"]))
                        dash.V_QtdAcidente.Add(rs.GetInt32(1));
                }
        }

        public void fechar_conexao()
        {
            ligacao.Close();
        }

    }
}
