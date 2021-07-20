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
    public partial class FrmCadastrarVia : Form
    {
        public FrmCadastrarVia()
        {
            InitializeComponent();
        }

        public void carregar_combo_provincia()
        {
            string aux;
            List<Provincia> provincias = new ProvinciaDAO(Util.CAMINHO_INICIAL).getAll();

            foreach (Provincia provincia in provincias)
            {
                aux = provincia.IdProvincia + "- " + provincia.Nome;
                cmb_provincia.AddItem(aux);
            }
        }

        public void carregar_combo_municipio(List<Municipio> lista)
        {
            string aux;
            foreach (Municipio municipio in lista)
            {
                aux = municipio.IdMunicipio + "- " + municipio.Nome;
                cmb_municipio.AddItem(aux);
            }
        }

        public bool verificar_campos()
        {
            if (txt_nome.Text.Trim().Equals(string.Empty) || cmb_municipio.selectedIndex == -1)
                return false;
            return true;
        }

        public void limpar_campos()
        {
            txt_nome.Text = string.Empty;
            txt_descricao.Text = string.Empty;
            cmb_provincia.selectedIndex = -1;
            cmb_municipio.selectedIndex = -1;            
        }
        
        public void operacao_inserir()
        {
            if (verificar_campos())
            {
                Via via = new Via();
                via.Nome = txt_nome.Text.Trim();

                string aux = cmb_municipio.selectedValue;
                Municipio municipio = new Municipio();
                municipio.IdMunicipio = Convert.ToInt32(aux.Substring(0, aux.IndexOf('-')));

                via.Municipio = municipio;
                via.Descricao = txt_descricao.Text.Trim();

                ViaDAO dao = new ViaDAO(Util.CAMINHO_INICIAL);
                dao.inserir(via);

                MessageBox.Show("Salvo!!");
            }
            else
            {
                MessageBox.Show("Alguns campos não foram preenchidos!");
                limpar_campos();
            }
        }

        private void FrmCadastrarVia_Load(object sender, EventArgs e)
        {                  
            carregar_combo_provincia();
        }

        private void cmb_provincia_onItemSelected(object sender, EventArgs e)
        {
            string valor = cmb_provincia.selectedValue;
            int idProvincia = Convert.ToInt32(valor.Substring(0, valor.IndexOf('-')));
            List<Municipio> lista = new MunicipioDAO(Util.CAMINHO_INICIAL).getMunicipioByProvincia(idProvincia);
            cmb_municipio.Clear();
            carregar_combo_municipio(lista);            
                        
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            operacao_inserir();            
        }
    }
}
