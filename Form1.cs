using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            DALAgenda.CriarBancoSQLite();
            DALAgenda.CriarTabelaSQLite();
            ExibirDados();
            lbDados.Text = DALAgenda.path;
        }

        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DALAgenda.GetContatos();
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtID.Text);
                contato.Nome = txtNOME.Text;
                contato.Email = txtEMAIL.Text;

                DALAgenda.Add(contato);
                ExibirDados();

                txtNOME.Clear();
                txtEMAIL.Clear();
                txtID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtID.Text);
                contato.Nome = txtNOME.Text;
                contato.Email = txtEMAIL.Text;

                DALAgenda.Update(contato);
                ExibirDados();

                txtNOME.Clear();
                txtEMAIL.Clear();
                txtID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                DALAgenda.Delete(id);
                ExibirDados();

                txtNOME.Clear();
                txtEMAIL.Clear();
                txtID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (txtID.Text !="")
                {
                    int id = Convert.ToInt32(txtID.Text);
                    dt = DALAgenda.GetContato(id);
                }
                else
                {
                    string nome = txtNOME.Text;
                    dt = DALAgenda.GetContatos(nome);
                }
                dgvDados.DataSource = dt;
                txtNOME.Clear();
                txtEMAIL.Clear();
                txtID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
