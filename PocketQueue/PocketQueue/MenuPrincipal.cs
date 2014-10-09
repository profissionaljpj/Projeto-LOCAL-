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
            this.Text = usuario.TipoUsuario.DescricaoUsuario;
        }

        private void botaoEmitirSenhas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmissaoSenhas emissaoSenhas = new EmissaoSenhas();
            DialogResult dialogResult = emissaoSenhas.ShowDialog();
            this.Show();
        }
    }
}
