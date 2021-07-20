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
    public partial class FrmOperacoesCondutor : Form
    {
        public FrmOperacoesCondutor()
        {
            InitializeComponent();
        }

        public void popular_gridview()
        {
            CondutorDAO dao = new CondutorDAO(Util.CAMINHO_INICIAL);
            List<Condutor> lista = dao.getAll();

            dataGridView1.Rows.Clear();
            foreach (Condutor condutor in lista)
            {
                string[] row = new string[4];
                row[0] = condutor.Pessoa.IdPessoa.ToString();
                row[1] = condutor.Pessoa.Nome;
                row[2] = condutor.Pessoa.DataNascimento.ToShortDateString();
                row[3] = condutor.Pessoa.Sexo;                

                dataGridView1.Rows.Add(row);
            }
        }

        public bool verificar_campos()
        {
            if(txt_nome.Text.Equals(string.Empty) || cmb_sexo.Text.Equals(string.Empty))
                return false;
            return true;
        }

        public void limpar_campos()
        {
            txt_nome.Text = string.Empty;
            cmb_sexo.Text = string.Empty;
        }

        private void FrmOperacoesCondutor_Load(object sender, EventArgs e)
        {
            cmb_sexo.Items.Add("Masculino");
            cmb_sexo.Items.Add("Feminino");
            popular_gridview();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lbl_id.Text = dataGridView1.CurrentRow.Cells["IdCondutor"].Value.ToString();
                txt_nome.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                cmb_sexo.Text = dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString();

                string[] data = dataGridView1.CurrentRow.Cells["Data"].Value.ToString().Split('-');
                int dia = Convert.ToInt32(data[0]);
                int mes = Convert.ToInt32(data[1]);                
                int ano = Convert.ToInt32(data[2]);
                DateTime dt = new DateTime(ano, mes, dia);

                data_nascimento.Value = dt;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Desejas realmente eliminar o condutor seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCondutor"].Value);

                    try
                    {
                        PessoaDAO dao = new PessoaDAO(Util.CAMINHO_INICIAL);
                        dao.eliminar(id);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally { MessageBox.Show("Eliminado com sucesso!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); popular_gridview(); }
                }
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (verificar_campos())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.IdPessoa = Convert.ToInt32(lbl_id.Text);
                pessoa.Nome = txt_nome.Text.Trim();
                pessoa.Sexo = cmb_sexo.Text;
                pessoa.DataNascimento = data_nascimento.Value;

                try
                {
                    PessoaDAO dao = new PessoaDAO(Util.CAMINHO_INICIAL);
                    dao.editar(pessoa);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { MessageBox.Show("Alterado com sucesso!", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information); limpar_campos(); popular_gridview(); }
            }
        }
    }
}
