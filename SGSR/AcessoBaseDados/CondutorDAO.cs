using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class CondutorDAO
    {
        SqlCeConnection ligacao;
        string caminho;

        public CondutorDAO(string caminho)
        {
            this.caminho = caminho;
            ligacao = Conexao.getConexao(caminho);            
        }

        public void inserir(Pessoa pessoa)
        {            
            string sql = "INSERT INTO tb_condutor(id_condutor) VALUES(@id_condutor)";
            
            PessoaDAO dao = new PessoaDAO(caminho);
            dao.inserir(pessoa);
            Pessoa p = dao.findLastId();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id_condutor", p.IdPessoa);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            ligacao.Close();
        }        

        public void eliminar(int id)
        {
            string sql = "DELETE FROM tb_condutor WHERE id_condutor = @id";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);
                comando.ExecuteNonQuery();
                ligacao.Close();
            }
            catch (Exception) { throw; }
        }

        public List<Condutor> getAll()
        {
            string sql = "SELECT id_condutor, p.nome as nome, p.sexo as sexo, p.data_nascimento as data FROM tb_condutor c INNER JOIN tb_pessoa p ON c.id_condutor = p.id_pessoa";
            List<Condutor> lista = new List<Condutor>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Condutor condutor = new Condutor();
                    Pessoa pessoa = new Pessoa();
                    if (!Convert.IsDBNull(rs["id_condutor"]))
                        pessoa.IdPessoa = rs.GetInt32(0);
                    if (!Convert.IsDBNull(rs["nome"]))
                        pessoa.Nome = rs.GetString(1);
                    if (!Convert.IsDBNull(rs["sexo"]))
                        pessoa.Sexo = rs.GetString(2);
                    if (!Convert.IsDBNull(rs["data"]))
                        pessoa.DataNascimento = rs.GetDateTime(3);

                    condutor.Pessoa = pessoa;
                    lista.Add(condutor);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            ligacao.Close();
            return lista;
        }

    }
}
