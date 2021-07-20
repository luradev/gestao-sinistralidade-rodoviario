using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class ContaDAO
    {
        SqlCeConnection ligacao;

        public ContaDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Conta conta)
        {
            string sql = "INSERT INTO tb_login(nome,perfil,senha) VALUES(@nome,@perfil,@senha)";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", conta.Nome);
                comando.Parameters.AddWithValue("perfil", conta.Perfil);
                comando.Parameters.AddWithValue("senha", conta.Senha);

                comando.ExecuteNonQuery();
                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public bool autenticar(Conta conta)
        {
            bool output = false;
            string sql = "SELECT * FROM tb_login WHERE nome = @nome AND senha = @senha";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", conta.Nome);
                comando.Parameters.AddWithValue("senha", conta.Senha);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())                
                    output = true;

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return output;
        }

        public List<Conta> getAll()
        {
            string sql = "SELECT id_usuario, nome, perfil, senha FROM tb_login";
            List<Conta> lista = new List<Conta>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Conta conta = new Conta();
                    if (!Convert.IsDBNull(rs["id_usuario"]))
                        conta.IdConta = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        conta.Nome = rs.GetString(1);
                    if (!Convert.IsDBNull(rs["perfil"]))
                        conta.Perfil = rs.GetString(2);
                    if (!Convert.IsDBNull(rs["senha"]))
                        conta.Senha = rs.GetString(3);

                    lista.Add(conta);
                }

                ligacao.Close();

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return lista;
        }
    }
}
