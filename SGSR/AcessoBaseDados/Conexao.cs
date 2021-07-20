using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace AcessoBaseDados
{
    class Conexao
    {
        private static SqlCeConnection con;

        public static SqlCeConnection getConexao(string caminho)
        {
            try
            {
                con = new SqlCeConnection();
                con.ConnectionString = "Data Source = " + caminho + @"/bd_sinistralidade.sdf";
                con.Open();
            }
            catch (Exception ex) { Console.WriteLine("A EXCECAO: " + ex.ToString()); }            

            return con;
        }
    }
}
