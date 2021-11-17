using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1FREDERICO13.Code.DTO;
using _3A1FREDERICO13.Code.BLL;

namespace _3A1FREDERICO13.Ui
{
    public partial class Login : Form
    {
        UsuarioBLL usuariobll = new UsuarioBLL();
        UsuarioDTO usuariodto = new UsuarioDTO();
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuariodto.Email = txtEmail.Text;
            usuariodto.Senha = txtSenha.Text;

            if (usuariobll.RealizarLogin(usuariodto) == true)
            {
                Oculos formOculos = new Oculos();
                formOculos.ShowDialog();

            }
            else
            {
                MessageBox.Show("Verfique email e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
