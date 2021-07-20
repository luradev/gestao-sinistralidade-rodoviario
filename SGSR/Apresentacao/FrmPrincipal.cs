using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFormCorrente(object formCorrente)
        {
            if (this.panelContentor.Controls.Count > 0)
            {
                this.panelContentor.Controls.RemoveAt(0);
            }
            Form fh = formCorrente as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContentor.Controls.Add(fh);
            this.panelContentor.Tag = fh;
            fh.Show();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itm_cadastrar_acidente_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmCadastrarAcidente());
        }

        private void itm_cadastrar_condutor_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmCadastrarCondutor());
        }

        private void itm_cadastrar_veiculo_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmCadastrarVeiculo());
        }

        private void itm_consulta_acidente_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmPesquisarAcidente());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmHome());
        }

        private void itm_cadastrar_via_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmCadastrarVia());
        }

        private void menu_estatistica_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmDashboard());
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void itm_op_veiculo_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmOperacoesVeiculo());
        }

        private void itm_op_condutor_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmOperacoesCondutor());
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            abrirFormCorrente(new FrmHome());
        }

    }
}
