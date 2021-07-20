using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class PessoaDAO
    {
        private static SqlCeConnection ligacao;

        public PessoaDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Pessoa pessoa)
        {
            string sql = "INSERT INTO tb_pessoa(nome,data_nascimento,sexo) values(@nome,@data_nascimento,@sexo)";
            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", pessoa.Nome);
                comando.Parameters.AddWithValue("data_nascimento", pessoa.DataNascimento);
                comando.Parameters.AddWithValue("sexo", pessoa.Sexo);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }            
            //ligacao.Close();
        }

        public void editar(Pessoa pessoa)
        {
            string sql = "UPDATE tb_pessoa SET nome = @nome, data_nascimento = @data, sexo = @sexo WHERE id_pessoa = @id";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("nome", pessoa.Nome);
                comando.Parameters.AddWithValue("data", pessoa.DataNascimento);
                comando.Parameters.AddWithValue("sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("id", pessoa.IdPessoa);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception) { throw; }
 
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM tb_pessoa WHERE id_pessoa = @id";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception) { throw; }
        }

        public Pessoa findLastId()
        {
            string sql = "SELECT MAX(id_pessoa) AS Id FROM tb_pessoa";
            Pessoa p = new Pessoa();
            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())
                    p.IdPessoa = Convert.ToInt32(rs["Id"]);

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return p;
        }
        
    }
}
