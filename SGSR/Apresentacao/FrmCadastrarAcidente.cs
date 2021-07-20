using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcessoBaseDados;
using ObjectosModelos;

namespace Apresentacao
{
    public partial class FrmCadastrarAcidente : Form
    {
        string CorrectFilename;
        string CompleteFileName;
        public static string nome_completo;

        public FrmCadastrarAcidente()
        {
            InitializeComponent();
        }

/*---------------------------------------------MÉTODOS ------------------------------------------------------------------------*/
        public static bool existe_imagem(string nome)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Util.FOTOS_PATH);
            System.IO.FileInfo[] fi = di.GetFiles();

            try
            {
                foreach (System.IO.FileInfo file in fi)
                {
                    if (nome.Contains(file.Name))
                    {
                        nome_completo = file.FullName;
                        return true;
                    }
                }
            }
            catch (NullReferenceException ex) { MessageBox.Show(ex.ToString()); }

            return false;
        }

        public void copiarParaDiretorio()
        {
            if (txt_imagem.Text != "")
                if (!existe_imagem(CorrectFilename))
                    System.IO.File.Copy(CompleteFileName, Application.StartupPath + @"/Fotos/" + CorrectFilename);
        }

        public void popular_gridview()
        {
            List<Acidente> lista = new AcidenteDAO(Util.CAMINHO_INICIAL).getAll();
            dataGridView1.Rows.Clear();

            foreach (Acidente acidente in lista)
            {
                string[] row = new string[8];
                row[0] = acidente.DataAcidente.ToShortDateString();
                row[1] = acidente.Via.Municipio.Nome;
                row[2] = acidente.Via.Nome;
                row[3] = acidente.Periodo;
                row[4] = acidente.Veiculo.Matricula;
                row[5] = acidente.Veiculo.ModeloVeiculo.Nome;
                row[6] = acidente.Condutor.Pessoa.Nome;
                row[7] = acidente.Classificacao.Designacao;
                //row[8] = acidente.Imagem;

                dataGridView1.Rows.Add(row);
            }
        }

        public void carregar_combo_classificacao()
        {
            List<ClassificacaoAcidente> lista = new ClassificacaoAcidenteDAO(Util.CAMINHO_INICIAL).getAll();
            string aux;
            cmb_classificacao.Clear();
            foreach (ClassificacaoAcidente c in lista)
            {
                aux = c.IdClassificacao + "- " + c.Designacao;
                cmb_classificacao.AddItem(aux);
            }
        }

        public void carregar_cmb_condutor()
        {
            List<Condutor> lista = new CondutorDAO(Util.CAMINHO_INICIAL).getAll();
            string aux;
            cmb_condutor.Clear();
            foreach (Condutor condutor in lista)
            {
                aux = condutor.Pessoa.IdPessoa + "- " + condutor.Pessoa.Nome;
                cmb_condutor.AddItem(aux);
            }
        }

        public void carregar_cmb_veiculo()
        {
            List<Veiculo> lista = new VeiculoDAO(Util.CAMINHO_INICIAL).getAll();
            string aux;
            cmb_veiculo.Clear();
            foreach (Veiculo veiculo in lista)
            {
                aux = veiculo.IdVeiculo + "- " + veiculo.Matricula;
                cmb_veiculo.AddItem(aux);
            }

            //List<String> lista = new VeiculoDAO(Util.CAMINHO_INICIAL).getAllConcatenado();

            //foreach (String veiculo in lista)
            //{
            //    cmb_veiculo.AddItem(veiculo.ToString());
            //}
        }

        public void carregar_combo_periodo()
        {
            string[] periodos = { "Manhã", "Tarde", "Noite" };
            cmb_periodo.Clear();
            foreach (String periodo in periodos)
                cmb_periodo.AddItem(periodo);            
        }

        public void carregar_cmb_provincia()
        {
            List<Provincia> lista = new ProvinciaDAO(Util.CAMINHO_INICIAL).getAll();
            string aux;
            
            foreach (Provincia provincia in lista)
            {
                aux = provincia.IdProvincia + "- " + provincia.Nome;
                cmb_provincia.AddItem(aux);
            }
        }

        public void carregar_cmb_categoria()
        {
            vitima_cmb_categoria.AddItem("Mortal");
            vitima_cmb_categoria.AddItem("Ferido");
        }

        public void carregar_cmb_municipio(List<Municipio> lista)
        {
            string aux;
            foreach (Municipio municipio in lista)
            {
                aux = municipio.IdMunicipio + "- " + municipio.Nome;
                cmb_municipio.AddItem(aux);
            }
        }

        public void carregar_cmb_via(List<Via> lista)
        {
            string aux;
            foreach (Via via in lista)
            {
                aux = via.IdVia + "- " + via.Nome;
                cmb_via.AddItem(aux);
            }
        }

        public void popular_listbox()
        {            
            List<Vitima> lista = Util.getVitimas();
            listbox_vitima.Items.Clear();
            foreach (Vitima vitima in lista)
            {
                listbox_vitima.Items.Add(vitima.Nome);                               
            }
        }

        public bool verificar_campos()
        {
            if (cmb_veiculo.selectedIndex == -1 || cmb_condutor.selectedIndex == -1 || cmb_classificacao.selectedIndex == -1 || cmb_via.selectedIndex == -1)
                return false;
            return true;
        }

        public void limpar_campos()
        {
            listbox_vitima.Items.Clear();
            txt_descricao.Text = string.Empty;
            txt_imagem.Text = string.Empty;
            carregar_combo_periodo();
            carregar_combo_classificacao();
            carregar_cmb_veiculo();
            carregar_cmb_condutor();
            //carregar_cmb_provincia();
        }

        public void limpar_campos_popup()
        {
            vitima_txt_nome.Text = string.Empty;
            vitima_cmb_categoria.selectedIndex = -1;
            vitima_txt_descricao.Text = string.Empty;
        }

        public void inserir_vitimas(int idAcidente)
        {
            List<Vitima> lista = Util.getVitimas();

            if (lista.Count > 0)
            {
                foreach (Vitima vitima in lista)
                {
                    Acidente acidente = new Acidente();
                    acidente.IdAcidente = idAcidente;

                    vitima.Acidente = acidente;
                    VitimaDAO dao = new VitimaDAO(Util.CAMINHO_INICIAL);
                    dao.inserir(vitima);
                }
                MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Util.reset_lista();
                limpar_campos();
            }
                        
        }
        
        public void acao_inserir()
        {
            if (verificar_campos())
            {
                Acidente acidente = new Acidente();
                acidente.DataAcidente = data_acidente.Value;
                acidente.Periodo = cmb_periodo.selectedValue;
                acidente.Imagem = txt_imagem.Text;
                acidente.Descricao = txt_descricao.Text.Trim();

                string idVeiculo = cmb_veiculo.selectedValue;
                Veiculo veiculo = new Veiculo();
                veiculo.IdVeiculo = Convert.ToInt32(idVeiculo.Substring(0, idVeiculo.IndexOf('-')));

                string idCondutor = cmb_condutor.selectedValue;
                Pessoa pessoa = new Pessoa();
                pessoa.IdPessoa = Convert.ToInt32(idCondutor.Substring(0, idCondutor.IndexOf('-')));
                Condutor condutor = new Condutor();
                condutor.Pessoa = pessoa;

                string idClasse = cmb_classificacao.selectedValue;
                ClassificacaoAcidente ca = new ClassificacaoAcidente();
                ca.IdClassificacao = Convert.ToInt32(idClasse.Substring(0, idClasse.IndexOf('-')));

                string idVia = cmb_via.selectedValue;
                Via via = new Via();
                via.IdVia = Convert.ToInt32(idVia.Substring(0, idVia.IndexOf('-')));

                acidente.Veiculo = veiculo;
                acidente.Condutor = condutor;
                acidente.Classificacao = ca;
                acidente.Via = via;

                new AcidenteDAO(Util.CAMINHO_INICIAL).inserir(acidente);
                copiarParaDiretorio();
                popular_gridview();                

            }
            else
            {
                MessageBox.Show("Alguns campos não foram preenchidos!");
                limpar_campos();
            }
        }

/*---------------------------------------------MÉTODOS ------------------------------------------------------------------------*/                                       

        private void FrmCadastrarAcidente_Load(object sender, EventArgs e)
        {
            popular_gridview();
            carregar_combo_classificacao();
            carregar_combo_periodo();
            carregar_cmb_condutor();
            carregar_cmb_veiculo();
            carregar_cmb_provincia();
            carregar_cmb_categoria();
        }

        private void cmb_provincia_onItemSelected(object sender, EventArgs e)
        {
            string valor = cmb_provincia.selectedValue;
            int idProvincia = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));
            List<Municipio> lista = new MunicipioDAO(Util.CAMINHO_INICIAL).getMunicipioByProvincia(idProvincia);
            cmb_municipio.Clear();
            carregar_cmb_municipio(lista);
        }                                 
       
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Imagens(JPG) | *.jpg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (opf.CheckFileExists)
                {
                    CorrectFilename = System.IO.Path.GetFileName(opf.FileName);
                    CompleteFileName = opf.FileName;
                    txt_imagem.Text = CorrectFilename;
                }
            }
        }

        private void cmb_municipio_onItemSelected(object sender, EventArgs e)
        {
            string valor = cmb_municipio.selectedValue;
            int idMunicipio = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));
            List<Via> lista = new ViaDAO(Util.CAMINHO_INICIAL).getViaByMunicipio(idMunicipio);
            cmb_via.Clear();
            carregar_cmb_via(lista);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            acao_inserir();
            Acidente acidente = new AcidenteDAO(Util.CAMINHO_INICIAL).getLastId();
            inserir_vitimas(acidente.IdAcidente);            
        }

        private void vitima_btn_add_Click(object sender, EventArgs e)
        {
            Vitima vitima = new Vitima();

            if (vitima_cmb_categoria.selectedIndex != -1)
            {
                if (vitima_txt_nome.Text.Trim().Equals(string.Empty))
                    vitima.Nome = "Desconhecido(a)";
                else
                    vitima.Nome = vitima_txt_nome.Text.Trim();

                vitima.Categoria = vitima_cmb_categoria.selectedValue;
                vitima.Descricao = vitima_txt_descricao.Text.Trim();
                Util.adicionar_vitima(vitima);

                popular_listbox();
                limpar_campos_popup();
            }
            else
                MessageBox.Show("Seleccione a categoria da vítima!");
        }

        private void vitima_btn_retirar_Click(object sender, EventArgs e)
        {
            int indice = listbox_vitima.SelectedIndex;
            Util.remover_vitima(indice);
            popular_listbox();
        }        
        
    }
}
