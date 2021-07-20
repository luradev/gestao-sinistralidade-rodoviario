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
    public partial class FrmPesquisarAcidente : Form
    {
        public FrmPesquisarAcidente()
        {
            InitializeComponent();
        }

        public void popular_gridview(List<Acidente> lista)
        {            
            dataGridView1.Rows.Clear();

            foreach (Acidente acidente in lista)
            {
                string[] row = new string[10];
                row[0] = acidente.DataAcidente.ToShortDateString();
                row[1] = acidente.Via.Municipio.Provincia.Nome;
                row[2] = acidente.Via.Municipio.Nome;
                row[3] = acidente.Via.Nome;
                row[4] = acidente.Periodo;
                row[5] = acidente.Veiculo.Matricula;
                row[6] = acidente.Veiculo.ModeloVeiculo.Nome;
                row[7] = acidente.Condutor.Pessoa.Nome;
                row[8] = acidente.Classificacao.Designacao;
                row[9] = acidente.IdAcidente.ToString();

                dataGridView1.Rows.Add(row);
            }
        }

        public void carregar_cmb_provincia()
        {
            List<Provincia> lista = new ProvinciaDAO(Util.CAMINHO_INICIAL).getAll();
            string aux;
            foreach (Provincia provincia in lista)
            {
                aux = provincia.IdProvincia + "- " + provincia.Nome;
                cmb_provincia.Items.Add(aux);
            }
        }

        public void carregar_cmb_municipio(List<Municipio> lista)
        {
            string aux;
            foreach (Municipio municipio in lista)
            {
                aux = municipio.IdMunicipio + "- " + municipio.Nome;
                cmb_municipio.Items.Add(aux);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DateTime dt1 = data_acidente_1.Value;
            DateTime dt2 = data_acidente_2.Value;
            List<Acidente> lista = null;
            string valor;

            if (rdb_provincia.Checked)
            {
                valor = cmb_provincia.Text;
                int idProvincia = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));
                lista = new AcidenteDAO(Util.CAMINHO_INICIAL).getByProvinciaIntervaloDeData(idProvincia, dt1, dt2);
            }
            else if (rdb_municipio.Checked)
            {
                valor = cmb_municipio.Text;
                int idMunicipio = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));
                lista = new AcidenteDAO(Util.CAMINHO_INICIAL).getByMunicipioIntervaloDeData(idMunicipio, dt1, dt2);
            }
            else
            {
                lista = new AcidenteDAO(Util.CAMINHO_INICIAL).getByIntervaloDeData(dt1, dt2);
            }            

            popular_gridview(lista);
        }

        private void rdb_municipio_CheckedChanged(object sender, EventArgs e)
        {
            cmb_provincia.Enabled = true;
            cmb_municipio.Enabled = true;
        }

        private void rdb_provincia_CheckedChanged(object sender, EventArgs e)
        {
            cmb_provincia.Enabled = true;
            cmb_municipio.Enabled = false;
            cmb_municipio.SelectedIndex = -1;
        }

        private void rdb_data_intervalo_CheckedChanged(object sender, EventArgs e)
        {
            cmb_provincia.Enabled = false;
            cmb_municipio.Enabled = false;
            cmb_provincia.SelectedIndex = -1;
            cmb_municipio.SelectedIndex = -1;
        }

        private void FrmPesquisarAcidente_Load(object sender, EventArgs e)
        {
            carregar_cmb_provincia();         
        }

        private void cmb_provincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string valor = cmb_provincia.Text;
            int idProvincia = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));
            List<Municipio> lista = new MunicipioDAO(Util.CAMINHO_INICIAL).getMunicipioByProvincia(idProvincia);
            cmb_municipio.Items.Clear();
            carregar_cmb_municipio(lista);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdAcidente"].Value);
            Acidente acidente = new AcidenteDAO(Util.CAMINHO_INICIAL).getAcidente(id);

            new FrmPopupVisualizar(acidente).ShowDialog();            
        }
    }
}
