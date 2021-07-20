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
    public partial class FrmCadastrarVeiculo : Form
    {
        public FrmCadastrarVeiculo()
        {
            InitializeComponent();
        }
        
    /*---------------------------------------MÉTODOS AUXILIARES ---------------------------------------------------------------------------*/        
        public void popular_gridview()
        {
            VeiculoDAO dao = new VeiculoDAO(Util.CAMINHO_INICIAL);
            List<Veiculo> lista = dao.getAll();
            
            dataGridView.Rows.Clear();
            foreach (Veiculo veiculo in lista)
            {
                string[] row = new string[6];
                row[0] = veiculo.IdVeiculo.ToString();
                row[1] = veiculo.Matricula;
                row[2] = veiculo.Lotacao.ToString();
                row[3] = veiculo.ModeloVeiculo.Nome;
                row[4] = veiculo.Tipo.Nome;

                dataGridView.Rows.Add(row);
            }

        }

        public void carregar_combo_marca()
        {
            string aux;
            List<Marca> marcas = new MarcaDAO(Util.CAMINHO_INICIAL).getAll();
            
            cmb_marca.Clear();
            modelo_cmb_marca.Clear();

            foreach (Marca marca in marcas)
            {
                aux = marca.Idmarca + "- " + marca.Nome;
                cmb_marca.AddItem(aux);
                modelo_cmb_marca.AddItem(aux);
            }
        }

        public void carregar_combo_modelo(List<Modelo> lista)
        {
            string aux;
            foreach (Modelo modelo in lista)
            {
                aux = modelo.IdModelo + "- " + modelo.Nome;
                cmb_modelo.AddItem(aux);
            }
        }

        public void carregar_combo_tipo()
        {
            string aux;
            List<TipoVeiculo> tipos = new TipoVeiculoDAO(Util.CAMINHO_INICIAL).getAll();

            cmb_tipo.Clear();
            foreach (TipoVeiculo tipo in tipos)
            {
                aux = tipo.Idtipo + "- " + tipo.Nome;
                cmb_tipo.AddItem(aux);
            }
        }

        public void popular_lista_marca()
        {
            List<Marca> lista = new MarcaDAO(Util.CAMINHO_INICIAL).getAll();
            list_marca.Items.Clear();
            foreach (Marca marca in lista)
            {
                list_marca.Items.Add(marca.Nome);
            }
        }

        public void popular_lista_modelo()
        {
            List<Modelo> lista = new ModeloDAO(Util.CAMINHO_INICIAL).getAll();
            list_modelo.Items.Clear();
            foreach (Modelo modelo in lista)
            {
                list_modelo.Items.Add(modelo.Nome);
            }
        }

        public void popular_lista_tipo()
        {
            List<TipoVeiculo> lista = new TipoVeiculoDAO(Util.CAMINHO_INICIAL).getAll();
            list_categoria.Items.Clear();
            foreach (TipoVeiculo tipo in lista)
            {
                list_categoria.Items.Add(tipo.Nome);
            }
        }
        
     /*---------------------------------------MÉTODOS AUXILIARES ---------------------------------------------------------------------------*/        

        private void FrmCadastrarVeiculo_Load(object sender, EventArgs e)
        {                                    
            carregar_combo_marca();
            carregar_combo_tipo();
            popular_gridview();
            popular_lista_marca();
            popular_lista_modelo();
            popular_lista_tipo();
        }

        private void cmb_marca_onItemSelected(object sender, EventArgs e)
        {
            string valor = cmb_marca.selectedValue;           
            int idMarca = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));            
            List<Modelo> lista = new ModeloDAO(Util.CAMINHO_INICIAL).getModeloByMarca(idMarca);
            cmb_modelo.Clear();
            carregar_combo_modelo(lista);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!txt_matricula.Text.Trim().Equals(string.Empty))
            {
                Veiculo veiculo = new Veiculo();
                veiculo.Matricula = txt_matricula.Text.Trim();
                veiculo.Lotacao = Convert.ToInt32(num_lotacao.Value);

                string idModelo = cmb_modelo.selectedValue;
                Modelo modelo = new Modelo();
                modelo.IdModelo = Convert.ToInt32(idModelo.Substring(0, idModelo.IndexOf('-')));
                veiculo.ModeloVeiculo = modelo;

                string idTipo = cmb_tipo.selectedValue;
                TipoVeiculo tipo = new TipoVeiculo();
                tipo.Idtipo = Convert.ToInt32(idTipo.Substring(0, idTipo.IndexOf('-')));
                veiculo.Tipo = tipo;

                VeiculoDAO dao = new VeiculoDAO(Util.CAMINHO_INICIAL);
                try
                {
                    dao.inserir(veiculo);
                }
                catch (Exception) { }
                finally { MessageBox.Show("Salvo com sucesso!","Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information); }                
                popular_gridview();
            }
            else
                MessageBox.Show("Alguns campos não foram preenchidos!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void modelo_btn_salvar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();

            if (modelo_txt_nome.Text.Equals(string.Empty) || modelo_cmb_marca.selectedIndex == -1)
                MessageBox.Show("Alguns campos não foram preenchidos!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                modelo.Nome = modelo_txt_nome.Text.Trim();
                string idMarca = modelo_cmb_marca.selectedValue;
                Marca marca = new Marca();
                marca.Idmarca = Convert.ToInt32(idMarca.Substring(0, idMarca.IndexOf('-')));

                modelo.Marca = marca;
                new ModeloDAO(Util.CAMINHO_INICIAL).inserir(modelo);
                MessageBox.Show("Salvo com sucesso!");
                modelo_txt_nome.Text = string.Empty;
                modelo_cmb_marca.selectedIndex = -1;
                popular_lista_modelo();
            }

        }

        private void marca_btn_salvar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            if (!marca_txt_nome.Text.Equals(string.Empty))
            {
                marca.Nome = marca_txt_nome.Text.Trim();
                try
                {
                    new MarcaDAO(Util.CAMINHO_INICIAL).inserir(marca);
                }
                catch (Exception) { }
                finally { MessageBox.Show("Salvo com sucesso!","Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                
                marca_txt_nome.Text = string.Empty;
                popular_lista_marca();
                carregar_combo_marca();
            }
            else
                MessageBox.Show("Alguns campos não foram preenchidos!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void categoria_btn_salvar_Click(object sender, EventArgs e)
        {
            TipoVeiculo tipo = new TipoVeiculo();
            if (!categoria_txt_nome.Text.Equals(string.Empty))
            {
                tipo.Nome = categoria_txt_nome.Text.Trim();
                new TipoVeiculoDAO(Util.CAMINHO_INICIAL).inserir(tipo);
                popular_lista_tipo();
                categoria_txt_nome.Text = string.Empty;
            }
            else
                MessageBox.Show("Alguns campos não foram preenchidos!", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
