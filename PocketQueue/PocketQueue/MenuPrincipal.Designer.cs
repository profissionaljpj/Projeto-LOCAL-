namespace PocketQueue
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoAdministracao = new System.Windows.Forms.Button();
            this.botaoAtendentes = new System.Windows.Forms.Button();
            this.botaoEmitirSenhas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoAdministracao
            // 
            this.botaoAdministracao.Location = new System.Drawing.Point(12, 12);
            this.botaoAdministracao.Name = "botaoAdministracao";
            this.botaoAdministracao.Size = new System.Drawing.Size(211, 23);
            this.botaoAdministracao.TabIndex = 0;
            this.botaoAdministracao.Text = "Painel de Administração";
            this.botaoAdministracao.UseVisualStyleBackColor = true;
            this.botaoAdministracao.Click += new System.EventHandler(this.botaoAdministracao_Click);
            // 
            // botaoAtendentes
            // 
            this.botaoAtendentes.Location = new System.Drawing.Point(12, 41);
            this.botaoAtendentes.Name = "botaoAtendentes";
            this.botaoAtendentes.Size = new System.Drawing.Size(211, 23);
            this.botaoAtendentes.TabIndex = 1;
            this.botaoAtendentes.Text = "Painel de Atendente";
            this.botaoAtendentes.UseVisualStyleBackColor = true;
            this.botaoAtendentes.Click += new System.EventHandler(this.botaoAtendentes_Click);
            // 
            // botaoEmitirSenhas
            // 
            this.botaoEmitirSenhas.Location = new System.Drawing.Point(12, 70);
            this.botaoEmitirSenhas.Name = "botaoEmitirSenhas";
            this.botaoEmitirSenhas.Size = new System.Drawing.Size(211, 23);
            this.botaoEmitirSenhas.TabIndex = 2;
            this.botaoEmitirSenhas.Text = "Emissão de Senhas";
            this.botaoEmitirSenhas.UseVisualStyleBackColor = true;
            this.botaoEmitirSenhas.Click += new System.EventHandler(this.botaoEmitirSenhas_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 102);
            this.Controls.Add(this.botaoEmitirSenhas);
            this.Controls.Add(this.botaoAtendentes);
            this.Controls.Add(this.botaoAdministracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoAdministracao;
        private System.Windows.Forms.Button botaoAtendentes;
        private System.Windows.Forms.Button botaoEmitirSenhas;
    }
}