using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using ObjectosModelos;

namespace AcessoBaseDados
{
    public class AcidenteDAO
    {
        SqlCeConnection ligacao;

        public AcidenteDAO(string caminho)
        {
            ligacao = Conexao.getConexao(caminho);
        }

        public void inserir(Acidente acidente)
        {
            string sql = "INSERT INTO tb_acidente(data_acidente,periodo,imagem,descricao,id_veiculo,id_condutor,id_classificacao_acidente,id_via) VALUES(@data,@periodo,@imagem,@descricao,@veiculo,@condutor,@classificacao,@via)";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);                
                comando.Parameters.AddWithValue("data", acidente.DataAcidente);
                comando.Parameters.AddWithValue("periodo", acidente.Periodo);
                comando.Parameters.AddWithValue("imagem", acidente.Imagem);
                comando.Parameters.AddWithValue("descricao", acidente.Descricao);
                comando.Parameters.AddWithValue("veiculo", acidente.Veiculo.IdVeiculo);
                comando.Parameters.AddWithValue("condutor", acidente.Condutor.Pessoa.IdPessoa);
                comando.Parameters.AddWithValue("classificacao", acidente.Classificacao.IdClassificacao);
                comando.Parameters.AddWithValue("via", acidente.Via.IdVia);
                comando.ExecuteNonQuery();

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                        
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM tb_acidente WHERE id_acidente = @id";

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("id", id);
                comando.ExecuteNonQuery();
                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public Acidente getLastId()
        {
            string sql = "SELECT MAX(id_acidente) AS Id FROM tb_acidente";
            Acidente acidente = new Acidente();
            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())
                {
                    if (!Convert.IsDBNull(rs["Id"]))
                        acidente.IdAcidente = rs.GetInt32(0); //Convert.ToInt32(rs["Id"]);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return acidente;
        }

        public Acidente getAcidente(int idAcidente)
        {
            string sql = "select a.id_acidente as id, a.data_acidente as data, pr.nome as provincia, mu.nome as local, vi.nome as via, a.periodo as periodo, v.matricula as veiculo, m.nome as modelo, p.nome as condutor, c.designacao as classificacao, a.imagem as img, a.descricao as descricao "
                + "from tb_acidente a inner join tb_veiculo v on a.id_veiculo = v.id_veiculo inner join tb_condutor cdt "
                + "on a.id_condutor = cdt.id_condutor inner join tb_pessoa p on cdt.id_condutor = p.id_pessoa "
                + "inner join tb_classificacao_acidente c on a.id_classificacao_acidente = c.id_classificacao_acidente "
                + "inner join tb_modelo_veiculo m on v.id_modelo_veiculo = m.id_modelo_veiculo inner join tb_via vi "
                + "on a.id_via = vi.id_via inner join tb_municipio mu on vi.id_municipio = mu.id_municipio "
                + "inner join tb_provincia pr on pr.id_provincia = mu.id_provincia "
                + "where a.id_acidente = @idAcidente ";

            List<Acidente> lista = new List<Acidente>();
            Acidente acidente = null;

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("idAcidente", idAcidente);
                SqlCeDataReader rs = comando.ExecuteReader();

                if (rs.Read())
                {
                    acidente = new Acidente();

                    if (!Convert.IsDBNull(rs["id"]))
                        acidente.IdAcidente = rs.GetInt32(0);

                    if (!Convert.IsDBNull(rs["data"]))
                        acidente.DataAcidente = rs.GetDateTime(1);

                    Provincia provincia = new Provincia();
                    if (!Convert.IsDBNull(rs["provincia"]))
                        provincia.Nome = rs.GetString(2);

                    Municipio municipio = new Municipio();
                    if (!Convert.IsDBNull(rs["local"]))
                        municipio.Nome = rs.GetString(3);

                    Via via = new Via();
                    if (!Convert.IsDBNull(rs["via"]))
                        via.Nome = rs.GetString(4);

                    if (!Convert.IsDBNull(rs["periodo"]))
                        acidente.Periodo = rs.GetString(5);

                    Veiculo veiculo = new Veiculo();
                    if (!Convert.IsDBNull(rs["veiculo"]))
                        veiculo.Matricula = rs.GetString(6);

                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["modelo"]))
                        modelo.Nome = rs.GetString(7);

                    Pessoa pessoa = new Pessoa();
                    if (!Convert.IsDBNull(rs["condutor"]))
                        pessoa.Nome = rs.GetString(8);

                    ClassificacaoAcidente classe = new ClassificacaoAcidente();
                    if (!Convert.IsDBNull(rs["classificacao"]))
                        classe.Designacao = rs.GetString(9);

                    if (!Convert.IsDBNull(rs["img"]))
                        acidente.Imagem = rs.GetString(10);

                    if (!Convert.IsDBNull(rs["descricao"]))
                        acidente.Descricao = rs.GetString(11);

                    Condutor condutor = new Condutor();
                    condutor.Pessoa = pessoa;
                    municipio.Provincia = provincia;
                    via.Municipio = municipio;
                    veiculo.ModeloVeiculo = modelo;

                    acidente.Veiculo = veiculo;
                    acidente.Condutor = condutor;
                    acidente.Classificacao = classe;
                    acidente.Via = via;
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return acidente;
                
        }

        public List<Acidente> getAll()
        {
            string sql = "select a.id_acidente as id, a.data_acidente as data, mu.nome as local, vi.nome as via, a.periodo as periodo, v.matricula as veiculo, m.nome as modelo, p.nome as condutor, c.designacao as classificacao, a.imagem as img "
                + "from tb_acidente a inner join tb_veiculo v on a.id_veiculo = v.id_veiculo inner join tb_condutor cdt "
                + "on a.id_condutor = cdt.id_condutor inner join tb_pessoa p on cdt.id_condutor = p.id_pessoa "
                + "inner join tb_classificacao_acidente c on a.id_classificacao_acidente = c.id_classificacao_acidente "
                + "inner join tb_modelo_veiculo m on v.id_modelo_veiculo = m.id_modelo_veiculo inner join tb_via vi "
                + "on a.id_via = vi.id_via inner join tb_municipio mu on vi.id_municipio = mu.id_municipio "
                + "order by a.data_acidente desc";

            List<Acidente> lista = new List<Acidente>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Acidente acidente = new Acidente();

                    if (!Convert.IsDBNull(rs["id"]))
                        acidente.IdAcidente = rs.GetInt32(0);

                    if (!Convert.IsDBNull(rs["data"]))
                        acidente.DataAcidente = rs.GetDateTime(1);

                    Municipio municipio = new Municipio();
                    if (!Convert.IsDBNull(rs["local"]))
                        municipio.Nome = rs.GetString(2);

                    Via via = new Via();
                    if (!Convert.IsDBNull(rs["via"]))
                        via.Nome = rs.GetString(3);

                    if (!Convert.IsDBNull(rs["periodo"]))
                        acidente.Periodo = rs.GetString(4);

                    Veiculo veiculo = new Veiculo();
                    if (!Convert.IsDBNull(rs["veiculo"]))
                        veiculo.Matricula = rs.GetString(5);

                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["modelo"]))
                        modelo.Nome = rs.GetString(6);

                    Pessoa pessoa = new Pessoa();
                    if (!Convert.IsDBNull(rs["condutor"]))
                        pessoa.Nome = rs.GetString(7);

                    ClassificacaoAcidente classe = new ClassificacaoAcidente();
                    if (!Convert.IsDBNull(rs["classificacao"]))
                        classe.Designacao = rs.GetString(8);

                    if (!Convert.IsDBNull(rs["img"]))
                        acidente.Imagem = rs.GetString(9);

                    Condutor condutor = new Condutor();
                    condutor.Pessoa = pessoa;
                    via.Municipio = municipio;
                    veiculo.ModeloVeiculo = modelo;

                    acidente.Veiculo = veiculo;
                    acidente.Condutor = condutor;
                    acidente.Classificacao = classe;
                    acidente.Via = via;

                    lista.Add(acidente);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }


        public List<Acidente> getByIntervaloDeData(DateTime data_1, DateTime data_2)
        {
            string sql = "select a.id_acidente as id, a.data_acidente as data, pr.nome as provincia, mu.nome as local, vi.nome as via, a.periodo as periodo, v.matricula as veiculo, m.nome as modelo, p.nome as condutor, c.designacao as classificacao, a.imagem as img "
                + "from tb_acidente a inner join tb_veiculo v on a.id_veiculo = v.id_veiculo inner join tb_condutor cdt "
                + "on a.id_condutor = cdt.id_condutor inner join tb_pessoa p on cdt.id_condutor = p.id_pessoa "
                + "inner join tb_classificacao_acidente c on a.id_classificacao_acidente = c.id_classificacao_acidente "
                + "inner join tb_modelo_veiculo m on v.id_modelo_veiculo = m.id_modelo_veiculo inner join tb_via vi "
                + "on a.id_via = vi.id_via inner join tb_municipio mu on vi.id_municipio = mu.id_municipio "
                + "inner join tb_provincia pr on pr.id_provincia = mu.id_provincia "
                + "where a.data_acidente between @data_1 and @data_2 "
                + "order by a.data_acidente desc";

            List<Acidente> lista = new List<Acidente>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("data_1", data_1);
                comando.Parameters.AddWithValue("data_2", data_2);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Acidente acidente = new Acidente();

                    if (!Convert.IsDBNull(rs["id"]))
                        acidente.IdAcidente = rs.GetInt32(0);

                    if (!Convert.IsDBNull(rs["data"]))
                        acidente.DataAcidente = rs.GetDateTime(1);

                    Provincia provincia = new Provincia();
                    if (!Convert.IsDBNull(rs["provincia"]))
                        provincia.Nome = rs.GetString(2);

                    Municipio municipio = new Municipio();
                    if (!Convert.IsDBNull(rs["local"]))
                        municipio.Nome = rs.GetString(3);

                    Via via = new Via();
                    if (!Convert.IsDBNull(rs["via"]))
                        via.Nome = rs.GetString(4);

                    if (!Convert.IsDBNull(rs["periodo"]))
                        acidente.Periodo = rs.GetString(5);

                    Veiculo veiculo = new Veiculo();
                    if (!Convert.IsDBNull(rs["veiculo"]))
                        veiculo.Matricula = rs.GetString(6);

                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["modelo"]))
                        modelo.Nome = rs.GetString(7);

                    Pessoa pessoa = new Pessoa();
                    if (!Convert.IsDBNull(rs["condutor"]))
                        pessoa.Nome = rs.GetString(8);

                    ClassificacaoAcidente classe = new ClassificacaoAcidente();
                    if (!Convert.IsDBNull(rs["classificacao"]))
                        classe.Designacao = rs.GetString(9);

                    if (!Convert.IsDBNull(rs["img"]))
                        acidente.Imagem = rs.GetString(10);

                    Condutor condutor = new Condutor();
                    condutor.Pessoa = pessoa;
                    municipio.Provincia = provincia;
                    via.Municipio = municipio;
                    veiculo.ModeloVeiculo = modelo;

                    acidente.Veiculo = veiculo;
                    acidente.Condutor = condutor;
                    acidente.Classificacao = classe;
                    acidente.Via = via;

                    lista.Add(acidente);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }


        public List<Acidente> getByProvinciaIntervaloDeData(int idProv, DateTime data_1, DateTime data_2)
        {
            string sql = "select a.id_acidente as id, a.data_acidente as data, pr.nome as provincia, mu.nome as local, vi.nome as via, a.periodo as periodo, v.matricula as veiculo, m.nome as modelo, p.nome as condutor, c.designacao as classificacao, a.imagem as img "
                + "from tb_acidente a inner join tb_veiculo v on a.id_veiculo = v.id_veiculo inner join tb_condutor cdt "
                + "on a.id_condutor = cdt.id_condutor inner join tb_pessoa p on cdt.id_condutor = p.id_pessoa "
                + "inner join tb_classificacao_acidente c on a.id_classificacao_acidente = c.id_classificacao_acidente "
                + "inner join tb_modelo_veiculo m on v.id_modelo_veiculo = m.id_modelo_veiculo inner join tb_via vi "
                + "on a.id_via = vi.id_via inner join tb_municipio mu on vi.id_municipio = mu.id_municipio "
                + "inner join tb_provincia pr on pr.id_provincia = mu.id_provincia "
                + "where pr.id_provincia = @idProv and a.data_acidente between @data_1 and @data_2 "
                + "order by a.data_acidente desc";

            List<Acidente> lista = new List<Acidente>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("idProv", idProv);
                comando.Parameters.AddWithValue("data_1", data_1);
                comando.Parameters.AddWithValue("data_2", data_2);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Acidente acidente = new Acidente();

                    if (!Convert.IsDBNull(rs["id"]))
                        acidente.IdAcidente = rs.GetInt32(0);

                    if (!Convert.IsDBNull(rs["data"]))
                        acidente.DataAcidente = rs.GetDateTime(1);

                    Provincia provincia = new Provincia();
                    if (!Convert.IsDBNull(rs["provincia"]))
                        provincia.Nome = rs.GetString(2);

                    Municipio municipio = new Municipio();
                    if (!Convert.IsDBNull(rs["local"]))
                        municipio.Nome = rs.GetString(3);

                    Via via = new Via();
                    if (!Convert.IsDBNull(rs["via"]))
                        via.Nome = rs.GetString(4);

                    if (!Convert.IsDBNull(rs["periodo"]))
                        acidente.Periodo = rs.GetString(5);

                    Veiculo veiculo = new Veiculo();
                    if (!Convert.IsDBNull(rs["veiculo"]))
                        veiculo.Matricula = rs.GetString(6);

                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["modelo"]))
                        modelo.Nome = rs.GetString(7);

                    Pessoa pessoa = new Pessoa();
                    if (!Convert.IsDBNull(rs["condutor"]))
                        pessoa.Nome = rs.GetString(8);

                    ClassificacaoAcidente classe = new ClassificacaoAcidente();
                    if (!Convert.IsDBNull(rs["classificacao"]))
                        classe.Designacao = rs.GetString(9);

                    if (!Convert.IsDBNull(rs["img"]))
                        acidente.Imagem = rs.GetString(10);

                    Condutor condutor = new Condutor();
                    condutor.Pessoa = pessoa;
                    municipio.Provincia = provincia;
                    via.Municipio = municipio;
                    veiculo.ModeloVeiculo = modelo;

                    acidente.Veiculo = veiculo;
                    acidente.Condutor = condutor;
                    acidente.Classificacao = classe;
                    acidente.Via = via;

                    lista.Add(acidente);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }

        public List<Acidente> getByMunicipioIntervaloDeData(int idMuni, DateTime data_1, DateTime data_2)
        {
            string sql = "select a.id_acidente as id, a.data_acidente as data, pr.nome as provincia, mu.nome as local, vi.nome as via, a.periodo as periodo, v.matricula as veiculo, m.nome as modelo, p.nome as condutor, c.designacao as classificacao, a.imagem as img "
                + "from tb_acidente a inner join tb_veiculo v on a.id_veiculo = v.id_veiculo inner join tb_condutor cdt "
                + "on a.id_condutor = cdt.id_condutor inner join tb_pessoa p on cdt.id_condutor = p.id_pessoa "
                + "inner join tb_classificacao_acidente c on a.id_classificacao_acidente = c.id_classificacao_acidente "
                + "inner join tb_modelo_veiculo m on v.id_modelo_veiculo = m.id_modelo_veiculo inner join tb_via vi "
                + "on a.id_via = vi.id_via inner join tb_municipio mu on vi.id_municipio = mu.id_municipio "
                + "inner join tb_provincia pr on pr.id_provincia = mu.id_provincia "
                + "where mu.id_municipio = @idMuni and a.data_acidente between @data_1 and @data_2 "
                + "order by a.data_acidente desc";

            List<Acidente> lista = new List<Acidente>();

            try
            {
                SqlCeCommand comando = new SqlCeCommand(sql, ligacao);
                comando.Parameters.AddWithValue("idMuni", idMuni);
                comando.Parameters.AddWithValue("data_1", data_1);
                comando.Parameters.AddWithValue("data_2", data_2);
                SqlCeDataReader rs = comando.ExecuteReader();

                while (rs.Read())
                {
                    Acidente acidente = new Acidente();

                    if (!Convert.IsDBNull(rs["id"]))
                        acidente.IdAcidente = rs.GetInt32(0);

                    if (!Convert.IsDBNull(rs["data"]))
                        acidente.DataAcidente = rs.GetDateTime(1);

                    Provincia provincia = new Provincia();
                    if (!Convert.IsDBNull(rs["provincia"]))
                        provincia.Nome = rs.GetString(2);

                    Municipio municipio = new Municipio();
                    if (!Convert.IsDBNull(rs["local"]))
                        municipio.Nome = rs.GetString(3);

                    Via via = new Via();
                    if (!Convert.IsDBNull(rs["via"]))
                        via.Nome = rs.GetString(4);

                    if (!Convert.IsDBNull(rs["periodo"]))
                        acidente.Periodo = rs.GetString(5);

                    Veiculo veiculo = new Veiculo();
                    if (!Convert.IsDBNull(rs["veiculo"]))
                        veiculo.Matricula = rs.GetString(6);

                    Modelo modelo = new Modelo();
                    if (!Convert.IsDBNull(rs["modelo"]))
                        modelo.Nome = rs.GetString(7);

                    Pessoa pessoa = new Pessoa();
                    if (!Convert.IsDBNull(rs["condutor"]))
                        pessoa.Nome = rs.GetString(8);

                    ClassificacaoAcidente classe = new ClassificacaoAcidente();
                    if (!Convert.IsDBNull(rs["classificacao"]))
                        classe.Designacao = rs.GetString(9);

                    if (!Convert.IsDBNull(rs["img"]))
                        acidente.Imagem = rs.GetString(10);

                    Condutor condutor = new Condutor();
                    condutor.Pessoa = pessoa;
                    municipio.Provincia = provincia;
                    via.Municipio = municipio;
                    veiculo.ModeloVeiculo = modelo;

                    acidente.Veiculo = veiculo;
                    acidente.Condutor = condutor;
                    acidente.Classificacao = classe;
                    acidente.Via = via;

                    lista.Add(acidente);
                }

                ligacao.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return lista;
        }
        


    }
}
