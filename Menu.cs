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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text.Equals("joao") && txtSenha.Text.Equals("123"))
                {
                    var agenda = new Agenda();
                    agenda.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }
            } catch { }
        }
    }
}
