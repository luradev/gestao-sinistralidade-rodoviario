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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            DashboardDAO dao = new DashboardDAO(Util.CAMINHO_INICIAL);
            dao.getAcidentesByClasses(dash);            
            dao.getMostSinistrados(dash);
            dao.getViasMaisSinistradas(dash);
                        
            chart_zonas_sinistra.Series[0].Points.DataBindXY(dash.Municipio, dash.QtdAcidente);
            chart_classificacao.Series[0].Points.DataBindXY(dash.Classificacao, dash.C_QtdAcidente);
            chart_vias_sinistra.Series[0].Points.DataBindXY(dash.Vias, dash.V_QtdAcidente);

            lbl_qtd_acidente.Text = dao.getTotalAcidente().ToString();
            lbl_qtd_condutor.Text = dao.getTotalCondutor().ToString();
            lbl_qtd_veiculo.Text = dao.getTotalVeiculo().ToString();

            dao.fechar_conexao();
        }
    }
}
