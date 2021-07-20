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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void limpar_campos()
        {
            txt_usuario.Text = "Usuário";
            txt_usuario.ForeColor = Color.DimGray;

            txt_senha.Text = "Senha";
            txt_senha.ForeColor = Color.DimGray;
            txt_senha.isPassword = false;
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Usuário")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Usuário";
                txt_usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            if (txt_senha.Text == "Senha")
            {
                txt_senha.Text = "";
                txt_senha.ForeColor = Color.LightGray;
                txt_senha.isPassword = true;
            }
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            if (txt_senha.Text == "")
            {
                txt_senha.Text = "Senha";
                txt_senha.ForeColor = Color.DimGray;
                txt_senha.isPassword = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_aceder_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Nome = txt_usuario.Text.Trim();
            conta.Senha = txt_senha.Text.Trim();
            
            ContaDAO dao = new ContaDAO(Util.CAMINHO_INICIAL);
            if (dao.autenticar(conta))
            {
                this.Hide();
                new FrmPrincipal().ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorrecta!");
            }
        }
    }
}
