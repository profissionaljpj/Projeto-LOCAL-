using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nomeTBox.Text;
            usuario.Cpf = cpfTBox.Text;
            usuario.Login = loginTBox.Text;
            usuario.Senha = senhaTBox.Text;
            usuario.TipoUsuario = tipoCBox.SelectedItem.ToString();
            IRepositorioUsuario repU = new RepositorioUsuario();
            repU.InserirUsuario(usuario);
            MessageBox.Show("Usuario registrado com sucessso!");
            Close();
        }
    }
}
