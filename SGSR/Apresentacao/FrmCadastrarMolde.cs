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
    public partial class FrmCadastrarMolde : Form
    {
        public FrmCadastrarMolde()
        {
            InitializeComponent();
        }

        private void btn_friso2_Click(object sender, EventArgs e)
        {
            if (panel2.Left == 513)
            {
                panel1.Visible = false;
                panel1.Left = 513;

                panel2.Visible = false;
                panel2.Left = 22;
                panel2.Visible = true;
                panel2.Refresh();

                bunifuSeparator1.Left = btn_friso2.Left;
                bunifuSeparator1.Width = btn_friso2.Width;
            }
        }

        private void btn_friso1_Click(object sender, EventArgs e)
        {
            if (panel1.Left == 513)
            {
                panel2.Visible = false;
                panel2.Left = 513;

                panel1.Visible = false;
                panel1.Left = 22;
                panel1.Visible = true;
                panel1.Refresh();

                bunifuSeparator1.Left = btn_friso1.Left;
                bunifuSeparator1.Width = btn_friso1.Width;
            }
        }
    }
}
