using DatabasePocketQueue.DAO.Entidades;
using PocketQueue.Entidades;
using PocketQueue.Factory;
using PocketQueue.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PocketQueue
{
    public partial class EmissaoSenhas : Form
    {
        WindowsMediaPlayer mediaPlayer;
        EmissaoSenhasService eSenhasService;

        public EmissaoSenhas()
        {
            InitializeComponent();
            eSenhasService = (EmissaoSenhasService)ServiceFactory.CriarService(Service.EmissaoSenhasService);
            mediaPlayer = new WindowsMediaPlayer();
            mediaPlayer.URL = eSenhasService.CaminhoAudio("\\Resources\\Doctor Jones.wma");
            mediaPlayer.controls.play();
        }

        private void botaoSenha_Click(object sender, EventArgs e)
        {
            Senha senha = eSenhasService.CriarSenha(ETipoSenha.Normal);
            if (senha != null) MessageBox.Show("Senha Emitida Com Sucesso!");
        }

        private void botaoSenhaPreferencial_Click(object sender, EventArgs e)
        {
            try
            {
                Senha senha = eSenhasService.CriarSenha(ETipoSenha.Preferencial);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (!eSenhasService.IsSenhaAtual() && eSenhasService.UltimaSenha != null)
            {
                Senha senha = eSenhasService.UltimaSenha;
                labelH8 = labelH7;
                labelH7 = labelH6;
                labelH6 = labelH5;
                labelH5 = labelH4;
                labelH4 = labelH3;
                labelH3.Text = "S: " + labelSenhaAtual.Text + "G: " + labelGuicheAtual.Text;
                labelSenhaAtual.Text = senha.IDSenha.ToString();
                labelGuicheAtual.Text = senha.Guiche.ToString();
                mediaPlayer.controls.play();
            }
        }
    }
}
