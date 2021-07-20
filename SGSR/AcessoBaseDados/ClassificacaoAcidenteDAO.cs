using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class ClassificacaoAcidenteDAO
    {
        SqlCeConnection ligacao;

        public ClassificacaoAcidenteDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public List<ClassificacaoAcidente> getAll()
        {
            string sql = "SELECT id_classificacao_acidente, designacao, descricao FROM tb_classificacao_acidente";
            List<ClassificacaoAcidente> lista = new List<ClassificacaoAcidente>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    ClassificacaoAcidente classificacao = new ClassificacaoAcidente();

                    if (!Convert.IsDBNull(rs["id_classificacao_acidente"]))
                        classificacao.IdClassificacao = Convert.ToInt32(rs.GetInt32(0));
                    if (!Convert.IsDBNull(rs["designacao"]))
                        classificacao.Designacao = rs.GetString(1);
                    if (!Convert.IsDBNull(rs["descricao"]))
                        classificacao.Descricao = rs.GetString(2);

                    lista.Add(classificacao);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }
    }
}
