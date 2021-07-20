using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class TipoVeiculoDAO
    {
        static SqlCeConnection ligacao;

        public TipoVeiculoDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(TipoVeiculo tipo)
        {
            string sql = "INSERT INTO tb_tipo_veiculo(nome) VALUES(@nome)";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", tipo.Nome);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public List<TipoVeiculo> getAll()
        {
            string sql = "SELECT id_tipo_veiculo, nome FROM tb_tipo_veiculo";
            List<TipoVeiculo> lista = new List<TipoVeiculo>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    TipoVeiculo tipo = new TipoVeiculo();

                    if (!Convert.IsDBNull(rs["id_tipo_veiculo"]))
                        tipo.Idtipo = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        tipo.Nome = rs.GetString(1);

                    lista.Add(tipo);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }

        public static int getID(string tipo)
        {
            string sql = "SELECT id_tipo_veiculo FROM tb_tipo_veiculo WHERE nome = @tipo";
            int id = 0;

            SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
            comando.Parameters.AddWithValue("tipo", tipo);
            SqlCeDataReader rs = comando.ExecuteReader();

            if (rs.Read())
            {
                if (!Convert.IsDBNull(rs["id_tipo_veiculo"]))
                    id = rs.GetInt32(0);
            }

            return id;
        }
    }
}
