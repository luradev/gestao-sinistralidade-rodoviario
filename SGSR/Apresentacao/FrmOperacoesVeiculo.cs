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
    public partial class FrmOperacoesVeiculo : Form
    {
        public FrmOperacoesVeiculo()
        {
            InitializeComponent();
        }

        /*---------------------------------------MÉTODOS AUXILIARES ---------------------------------------------------------------------------*/

        public void popular_gridview()
        {
            VeiculoDAO dao = new VeiculoDAO(Util.CAMINHO_INICIAL);
            List<Veiculo> lista = dao.getAll();

            dataGridView1.Rows.Clear();
            foreach (Veiculo veiculo in lista)
            {
                string[] row = new string[6];
                row[0] = veiculo.IdVeiculo.ToString();
                row[1] = veiculo.Matricula;
                row[2] = veiculo.Lotacao.ToString();
                row[3] = veiculo.ModeloVeiculo.Nome;
                row[4] = veiculo.Tipo.Nome;

                dataGridView1.Rows.Add(row);
            }

        }

        public void carregar_combo_marca()
        {
            string aux;
            List<Marca> marcas = new MarcaDAO(Util.CAMINHO_INICIAL).getAll();

            cmb_marca.Items.Clear();
            foreach (Marca marca in marcas)
            {
                aux = marca.Idmarca + "- " + marca.Nome;
                cmb_marca.Items.Add(aux);
                modelo_cmb_marca.Items.Add(aux);
            }
        }

        public void carregar_combo_modelo(List<Modelo> lista)
        {
            string aux;
            cmb_modelo.Text = string.Empty;
            foreach (Modelo modelo in lista)
            {
                aux = modelo.IdModelo + "- " + modelo.Nome;
                cmb_modelo.Items.Add(aux);
            }
        }

        public void carregar_combo_tipo()
        {
            List<TipoVeiculo> tipos = new TipoVeiculoDAO(Util.CAMINHO_INICIAL).getAll();
            cmb_tipo.Items.Clear();
            foreach (TipoVeiculo tipo in tipos)
            {
                cmb_tipo.Items.Add(tipo.Nome);
            }
        }

        public bool verificar_campos()
        {
            if (txt_matricula.Text.Equals(string.Empty) || cmb_marca.Text.Equals(string.Empty) || cmb_modelo.Text.Equals(string.Empty))
                return false;
            return true;
        }

        public void popular_lista_marca()
        {
            List<Marca> lista = new MarcaDAO(Util.CAMINHO_INICIAL).getAll();
            list_marca.Items.Clear();
            foreach (Marca marca in lista)
            {
                string aux = marca.Idmarca + "- " + marca.Nome;
                list_marca.Items.Add(aux);
                //list_marca.Items.Insert(0, marca.Idmarca);
                //list_marca.Items.Insert(1, marca.Nome);
            }
        }

        public void popular_lista_modelo()
        {
            List<Modelo> lista = new ModeloDAO(Util.CAMINHO_INICIAL).getAll();
            list_modelo.Items.Clear();
            foreach (Modelo modelo in lista)
            {
                string aux = modelo.IdModelo + "- " + modelo.Nome;
                list_modelo.Items.Add(aux);
            }
        }

        public void limpar_tab_veiculo()
        {
            lbl_id.Text = string.Empty;
            txt_matricula.Text = string.Empty;
            txt_lotacao.Text = string.Empty;
            cmb_marca.SelectedIndex = -1;
            cmb_modelo.SelectedIndex = -1;
            cmb_tipo.SelectedIndex = -1;
        }

        public void limpar_tab_modelo()
        {
            lbl_idModelo.Text = string.Empty;
            modelo_txt_nome.Text = string.Empty;
            modelo_cmb_marca.SelectedIndex = -1;
        }

        public void limpar_tab_marca()
        {
            lbl_MarcaID.Text = string.Empty;
            marca_txt_nome.Text = string.Empty;
        }

        /*---------------------------------------FIM MÉTODOS AUXILIARES ---------------------------------------------------------------------------*/

        private void FrmOperacoesVeiculo_Load(object sender, EventArgs e)
        {
            popular_gridview();
            popular_lista_marca();
            popular_lista_modelo();
            carregar_combo_marca();
            carregar_combo_tipo();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lbl_id.Text = dataGridView1.CurrentRow.Cells["IdVeiculo"].Value.ToString();
                txt_matricula.Text = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                txt_lotacao.Text = dataGridView1.CurrentRow.Cells["Lotacao"].Value.ToString();

                cmb_tipo.Text = dataGridView1.CurrentRow.Cells["Tipo"].Value.ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (verificar_campos())
            {
                Veiculo veiculo = new Veiculo();
                veiculo.IdVeiculo = Convert.ToInt32(lbl_id.Text);
                veiculo.Matricula = txt_matricula.Text.Trim();
                veiculo.Lotacao = Convert.ToInt32(txt_lotacao.Text.Trim());

                Modelo modelo = new Modelo();
                modelo.IdModelo = Convert.ToInt32(cmb_modelo.Text.Substring(0, cmb_modelo.Text.IndexOf('-')));


                TipoVeiculo tipo = new TipoVeiculo();
                tipo.Idtipo = TipoVeiculoDAO.getID(cmb_tipo.Text.Trim());

                veiculo.ModeloVeiculo = modelo;
                veiculo.Tipo = tipo;

                try
                {
                    VeiculoDAO dao = new VeiculoDAO(Util.CAMINHO_INICIAL);
                    dao.editar(veiculo);
                }
                catch (Exception) { }
                finally { MessageBox.Show("Alterado com sucesso!", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information); limpar_tab_veiculo(); popular_gridview(); }                
            }
            else
                MessageBox.Show("Alguns campos não foram preenchidos!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void cmb_marca_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = cmb_marca.Text;
            int idMarca = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));
            List<Modelo> lista = new ModeloDAO(Util.CAMINHO_INICIAL).getModeloByMarca(idMarca);
            cmb_modelo.Items.Clear();
            carregar_combo_modelo(lista);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Desejas realmente eliminar o veículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVeiculo"].Value);
                    //MessageBox.Show(id.ToString());
                    try
                    {
                        VeiculoDAO dao = new VeiculoDAO(Util.CAMINHO_INICIAL);
                        dao.eliminar(id);
                    }
                    catch (Exception) { }
                    finally { MessageBox.Show("Eliminado com sucesso!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); popular_gridview(); }
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                btn_editar.Enabled = false;
                btn_eliminar.Enabled = false;
            }
            else
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }

        private void modelo_btn_edit_Click(object sender, EventArgs e)
        {
            if (list_marca.SelectedIndex >= 0)
            {
                int id = Convert.ToInt32(list_modelo.Text.Substring(0, list_modelo.Text.IndexOf('-')));
                Modelo modelo = new ModeloDAO(Util.CAMINHO_INICIAL).getModeloByID(id);

                modelo_txt_nome.Text = modelo.Nome;
                lbl_idModelo.Text = id.ToString();
            }

        }

        private void modelo_btn_eliminar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (list_modelo.SelectedIndex >= 0)
            {
                id = Convert.ToInt32(list_modelo.Text.Substring(0, list_modelo.Text.IndexOf('-')));

                if (MessageBox.Show("Desejas realmente eliminar o modelo seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        ModeloDAO dao = new ModeloDAO(Util.CAMINHO_INICIAL);
                        dao.eliminar(id);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally { MessageBox.Show("Eliminado com sucesso!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); popular_lista_modelo(); }
                }
            }
            else
                MessageBox.Show("Seleccione o modelo a ser eliminado!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_modelo_salvar_Click(object sender, EventArgs e)
        {
            if (!modelo_cmb_marca.Text.Equals(string.Empty))
            {
                Modelo modelo = new Modelo();
                modelo.IdModelo = Convert.ToInt32(lbl_idModelo.Text);
                modelo.Nome = modelo_txt_nome.Text.Trim();
                Marca marca = new Marca();
                marca.Idmarca = Convert.ToInt32(modelo_cmb_marca.Text.Substring(0, modelo_cmb_marca.Text.IndexOf('-')));
                modelo.Marca = marca;

                try
                {
                    ModeloDAO dao = new ModeloDAO(Util.CAMINHO_INICIAL);
                    dao.editar(modelo);
                }
                catch (Exception) { throw; }
                finally { MessageBox.Show("Alterado com sucesso!", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information); limpar_tab_modelo(); popular_lista_modelo(); }
            }
            else
                MessageBox.Show("Alguns campos não foram preenchidos!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_marca_editar_Click(object sender, EventArgs e)
        {
            if (list_marca.SelectedIndex >= 0)
            {
                int id = Convert.ToInt32(list_marca.Text.Substring(0, list_marca.Text.IndexOf('-')));
                Marca marca = new MarcaDAO(Util.CAMINHO_INICIAL).getMarcaByID(id);

                lbl_MarcaID.Text = marca.Idmarca.ToString();
                marca_txt_nome.Text = marca.Nome;
            }
        }

        private void btn_marca_eliminar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (list_marca.SelectedIndex >= 0)
            {
                id = Convert.ToInt32(list_marca.Text.Substring(0, list_marca.Text.IndexOf('-')));

                if (MessageBox.Show("Desejas realmente eliminar a marca seleccionada?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        MarcaDAO dao = new MarcaDAO(Util.CAMINHO_INICIAL);
                        dao.eliminar(id);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally { MessageBox.Show("Eliminado com sucesso!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); popular_lista_marca(); }
                }
            }
            else
                MessageBox.Show("Seleccione a marca a ser eliminada!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void marca_btn_salvar_Click(object sender, EventArgs e)
        {
            if (!marca_txt_nome.Text.Equals(string.Empty))
            {
                Marca marca = new Marca();
                marca.Idmarca = Convert.ToInt32(lbl_MarcaID.Text);
                marca.Nome = marca_txt_nome.Text.Trim();                

                try
                {
                    MarcaDAO dao = new MarcaDAO(Util.CAMINHO_INICIAL);
                    dao.editar(marca);
                }
                catch (Exception) { throw; }
                finally { MessageBox.Show("Alterado com sucesso!", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information); limpar_tab_marca(); popular_lista_marca(); }
            }
            else
                MessageBox.Show("Alguns campos não foram preenchidos!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
