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
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        public void popular_gridview()
        {
            dataGridView1.DataSource = new ContaDAO(Util.CAMINHO_INICIAL).getAll();
        }

        public void carregar_combo()
        {
            cmb_perfil.AddItem("Administrador");
            cmb_perfil.AddItem("Usuário");
        }

        public bool verificar_campos()
        {
            if (txt_nome.Text.Trim().Equals(string.Empty) || txt_senha.Text.Trim().Equals(string.Empty) || cmb_perfil.selectedValue.Equals(string.Empty))
                return false;
            return true;
        }

        public void limpar_campos()
        {
            txt_nome.Text = string.Empty;
            txt_senha.Text = string.Empty;
            cmb_perfil.selectedIndex = -1;
            txt_nome.Focus();
        }

        public void operacao_salvar() 
        {
            if (verificar_campos())
            {
                Conta conta = new Conta();
                conta.Nome = txt_nome.Text.Trim();
                conta.Perfil = cmb_perfil.selectedValue;
                conta.Senha = txt_senha.Text.Trim();

                ContaDAO dao = new ContaDAO(Util.CAMINHO_INICIAL);
                dao.inserir(conta);
                MessageBox.Show("Cadastrado com sucesso!");
                limpar_campos();
                popular_gridview();
            }
            else
            {
                MessageBox.Show("Alguns campos não foram preenchidos!");
            }
        } 

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            popular_gridview();
            carregar_combo();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            operacao_salvar();
        }
    }
}
