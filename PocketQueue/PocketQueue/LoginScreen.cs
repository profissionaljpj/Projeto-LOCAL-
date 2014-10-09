using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using PocketQueue.Factory;
using PocketQueue.Services;

namespace PocketQueue
{
    public partial class LoginScreen : Form
    {
        LoginScreenService loginScreenService;

        public LoginScreen()
        {
            InitializeComponent();
        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            loginScreenService = (LoginScreenService)ServiceFactory.CriarService(Service.LoginScreenService);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            progressBar.PerformStep();           

            Usuario usuario = loginScreenService.ValidarLogin(loginTextBox.Text, passwordTextBox.Text);

            progressBar.PerformStep();

            if (usuario == null)
            {
                progressLabel.Text = "Falha.";
                MessageBox.Show("Usuário não encontrado, verifique se a" + Environment.NewLine + "senha foi digitada corretamente.");
                progressBar.Value = 0;
            }
            else
            {
                progressLabel.Text = "Sucesso!";
                MessageBox.Show("Bem vindo(a) " + usuario.Nome + " você está logado como: " + usuario.TipoUsuario.DescricaoUsuario);
                this.Hide();
                MenuPrincipal menu = new MenuPrincipal(usuario);
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
