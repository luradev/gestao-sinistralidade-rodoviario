using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjectosModelos;
using AcessoBaseDados;


namespace Apresentacao
{
    public partial class FrmCadastrarCondutor : Form
    {
        public string path = Application.StartupPath;
 
        public FrmCadastrarCondutor()
        {
            InitializeComponent();
        }

        public bool verificar_campos()
        {
            if (txt_nome.Text.Trim().Equals(string.Empty) || cmb_sexo.selectedValue.Equals(string.Empty))
                return false;
            return true;
        }

        public void limpar_campos()
        {
            txt_nome.Text = string.Empty;
            cmb_sexo.selectedIndex = -1;
            txt_nome.Focus();
        }

        public void popular_gridview()
        {
            CondutorDAO dao = new CondutorDAO(Util.CAMINHO_INICIAL);
            List<Condutor> lista = dao.getAll();

            dataGridView1.Rows.Clear();
            foreach (Condutor condutor in lista)
            {
                string[] row = new string[4];
                row[0] = condutor.Pessoa.IdPessoa.ToString();
                row[1] = condutor.Pessoa.Nome;
                row[2] = condutor.Pessoa.DataNascimento.ToShortDateString();
                row[3] = condutor.Pessoa.Sexo;

                dataGridView1.Rows.Add(row);
            }
        }

        public void operacao_salvar()
        {
            if (verificar_campos())
            {
                Pessoa p = new Pessoa();
                p.Nome = txt_nome.Text.Trim();
                p.Sexo = cmb_sexo.selectedValue;
                p.DataNascimento = data_nascimento.Value;

                try
                {
                    CondutorDAO dao = new CondutorDAO(path);
                    dao.inserir(p);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { MessageBox.Show("Salvo com sucesso!"); };

                limpar_campos();
            }
            else
            {
                MessageBox.Show("Alguns campos não foram preenchidos!");                
            }
        }
        
        private void FrmCadastrarPessoa_Load(object sender, EventArgs e)
        {
            cmb_sexo.AddItem("Masculino");
            cmb_sexo.AddItem("Feminino");
            popular_gridview();
        }
        
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            operacao_salvar();
            popular_gridview();
        }
        
    }
}
