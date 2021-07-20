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
    public partial class FrmPopupVisualizar : Form
    {
        Acidente acidente = null;
        string caminho_foto;

        public FrmPopupVisualizar(Acidente acidente)
        {
            InitializeComponent();
            this.acidente = acidente;
        }

        public void popular_listbox(int id)
        {            
            List<Vitima> lista = new VitimaDAO(Util.CAMINHO_INICIAL).getByAcidente(id);

            list_box_vitima.Items.Clear();
            foreach (Vitima vitima in lista)
            {
                list_box_vitima.Items.Add(vitima.Nome);
            }
        }

        public void preencher_campos(Acidente acidente)
        {           
            txt_id_acidente.Text = acidente.IdAcidente.ToString();
            txt_data.Text = acidente.DataAcidente.ToShortDateString().ToString();
            txt_periodo.Text = acidente.Periodo;
            txt_provincia.Text = acidente.Via.Municipio.Provincia.Nome;
            txt_municipio.Text = acidente.Via.Municipio.Nome;
            txt_via.Text = acidente.Via.Nome;
            txt_veiculo.Text = acidente.Veiculo.ModeloVeiculo.Nome + " - " + acidente.Veiculo.Matricula;
            txt_condutor.Text = acidente.Condutor.Pessoa.Nome;
            txt_classse.Text = acidente.Classificacao.Designacao;
            txt_descricao.Text = acidente.Descricao;

            try
            {
                if (Util.existe_foto(acidente.Imagem))
                {
                    caminho_foto = Util.getNomeCompleto();
                    pictureBox.Image = Image.FromFile(caminho_foto);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            popular_listbox(Convert.ToInt32(txt_id_acidente.Text));
        }

               
        private void FrmPopup_Load(object sender, EventArgs e)
        {
            preencher_campos(acidente);            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desejas realmente eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txt_id_acidente.Text);
                try
                {
                    new AcidenteDAO(Util.CAMINHO_INICIAL).eliminar(id);
                    pictureBox.Image.Dispose();
                    System.IO.File.Delete(caminho_foto);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { MessageBox.Show("Eliminado com sucesso!"); }

                this.Close();
            }
        }
    }
}
