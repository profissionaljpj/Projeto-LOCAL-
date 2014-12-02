using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuario;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            botaoAdministracao.Enabled = false;
            botaoAtendentes.Enabled = false;
            botaoEmitirSenhas.Enabled = false;

            this.Text = usuario.TipoUsuario;

            if (usuario.TipoUsuario.Equals("Gerente"))
            {
                botaoAdministracao.Enabled = botaoAtendentes.Enabled = botaoEmitirSenhas.Enabled = true;
            }

            if (usuario.TipoUsuario.Equals("Atendente"))
            {
                botaoAtendentes.Enabled = true;
            }

            if (usuario.TipoUsuario.Equals("Monitor")){
                botaoEmitirSenhas.Enabled = true;
            }
        }

        private void botaoEmitirSenhas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmissaoSenhas emissaoSenhas = new EmissaoSenhas();
            DialogResult dialogResult = emissaoSenhas.ShowDialog();
            this.Show();
        }

        private void botaoAtendentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAtendente tela = new TelaAtendente();
            DialogResult dialogResult = tela.ShowDialog();
            this.Show();
        }

        private void botaoAdministracao_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastroUsuario tela = new TelaCadastroUsuario();
            DialogResult dialogResult = tela.ShowDialog();
            this.Show();
        }
    }
}
