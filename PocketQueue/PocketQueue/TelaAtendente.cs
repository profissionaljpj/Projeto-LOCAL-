using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class TelaAtendente : Form
    {
        Senha senha;
        Stopwatch cronometro = new Stopwatch();
        string guiche;

        public TelaAtendente()
        {
            InitializeComponent();
        }

        private void TelaAtendente_Load(object sender, EventArgs e)
        {
            do
            {
                guiche = Microsoft.VisualBasic.Interaction.InputBox("Qual o seu Guichê?", "Insira o numero doGuichê Atual");
                if (!Information.IsNumeric(guiche))
                {
                    MessageBox.Show("Insira um numero para o Guichê");
                }
            }
            while (!Information.IsNumeric(guiche));
            Guichelabel.Text = guiche;
        }

        private void ChamarSenha_Button_Click(object sender, EventArgs e)
        {
            try
            {
                FinalizarAtendimento_Button.Enabled = true;
                ChamarSenha_Button.Enabled = false;
                cronometro.Reset();
                cronometro.Start();
                RepositorioSenha RS = new RepositorioSenha();
                senha = RS.ChamarSenha();
                senha.Guiche = Int32.Parse(guiche);
                senha.Atendido = DateTime.Now;
                senha.EstadoSenha = "Em Atendimento";
                RS.AlterarSenha(senha);
            }
            catch
            {
                MessageBox.Show("Não há senhas para chamar.");
                FinalizarAtendimento_Button_Click(sender, e);
            }
        }

        private void FinalizarAtendimento_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ChamarSenha_Button.Enabled = true;
                FinalizarAtendimento_Button.Enabled = false;
                cronometro.Stop();
                TempoFinal_Label.Text = Cronometro_Label.Text;
                cronometro.Reset();
                RepositorioSenha RS = new RepositorioSenha();
                senha.Resolvido = DateTime.Now;
                senha.EstadoSenha = "Atendido";
                RS.AlterarSenha(senha);
            }
            catch { }
        }

        private void Cronometro_Timer_Tick(object sender, EventArgs e)
        {
            Cronometro_Label.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds / 10);
        }

    }
}
