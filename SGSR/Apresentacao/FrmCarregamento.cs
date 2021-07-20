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
    public partial class FrmCarregamento : Form
    {
        public FrmCarregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress_bar.Value < 100)
                progress_bar.Value = progress_bar.Value + 2;
            else
            {
                timer1.Enabled = false;
                this.Hide();
                new FrmPrincipal().ShowDialog();
                //new FlatFormLogin().ShowDialog();
               // Application.Exit();
            }     
        }

        private void FrmCarregamento_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
