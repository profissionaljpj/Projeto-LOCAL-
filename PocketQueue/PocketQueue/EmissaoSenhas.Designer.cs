namespace PocketQueue
{
    partial class EmissaoSenhas
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
            this.components = new System.ComponentModel.Container();
            this.botaoSenha = new System.Windows.Forms.Button();
            this.botaoSenhaPreferencial = new System.Windows.Forms.Button();
            this.historico = new System.Windows.Forms.GroupBox();
            this.labelH8 = new System.Windows.Forms.Label();
            this.labelH7 = new System.Windows.Forms.Label();
            this.labelH6 = new System.Windows.Forms.Label();
            this.labelH5 = new System.Windows.Forms.Label();
            this.labelH4 = new System.Windows.Forms.Label();
            this.labelH3 = new System.Windows.Forms.Label();
            this.labelSenhaAtual = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelGuiche = new System.Windows.Forms.Label();
            this.labelGuicheAtual = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.historico.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoSenha
            // 
            this.botaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSenha.Location = new System.Drawing.Point(12, 177);
            this.botaoSenha.Name = "botaoSenha";
            this.botaoSenha.Size = new System.Drawing.Size(120, 85);
            this.botaoSenha.TabIndex = 0;
            this.botaoSenha.Text = "Gerar Senha";
            this.botaoSenha.UseVisualStyleBackColor = true;
            this.botaoSenha.Click += new System.EventHandler(this.botaoSenha_Click);
            // 
            // botaoSenhaPreferencial
            // 
            this.botaoSenhaPreferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSenhaPreferencial.Location = new System.Drawing.Point(145, 177);
            this.botaoSenhaPreferencial.Name = "botaoSenhaPreferencial";
            this.botaoSenhaPreferencial.Size = new System.Drawing.Size(120, 85);
            this.botaoSenhaPreferencial.TabIndex = 1;
            this.botaoSenhaPreferencial.Text = "Gerar Senha (Preferencial)";
            this.botaoSenhaPreferencial.UseVisualStyleBackColor = true;
            this.botaoSenhaPreferencial.Click += new System.EventHandler(this.botaoSenhaPreferencial_Click);
            // 
            // historico
            // 
            this.historico.Controls.Add(this.labelH8);
            this.historico.Controls.Add(this.labelH7);
            this.historico.Controls.Add(this.labelH6);
            this.historico.Controls.Add(this.labelH5);
            this.historico.Controls.Add(this.labelH4);
            this.historico.Controls.Add(this.labelH3);
            this.historico.Location = new System.Drawing.Point(145, 12);
            this.historico.Name = "historico";
            this.historico.Size = new System.Drawing.Size(120, 159);
            this.historico.TabIndex = 2;
            this.historico.TabStop = false;
            this.historico.Text = "Histórico";
            // 
            // labelH8
            // 
            this.labelH8.Location = new System.Drawing.Point(6, 131);
            this.labelH8.Name = "labelH8";
            this.labelH8.Size = new System.Drawing.Size(108, 23);
            this.labelH8.TabIndex = 5;
            this.labelH8.Text = "---";
            this.labelH8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH7
            // 
            this.labelH7.Location = new System.Drawing.Point(6, 108);
            this.labelH7.Name = "labelH7";
            this.labelH7.Size = new System.Drawing.Size(108, 23);
            this.labelH7.TabIndex = 4;
            this.labelH7.Text = "---";
            this.labelH7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH6
            // 
            this.labelH6.Location = new System.Drawing.Point(6, 85);
            this.labelH6.Name = "labelH6";
            this.labelH6.Size = new System.Drawing.Size(108, 23);
            this.labelH6.TabIndex = 3;
            this.labelH6.Text = "---";
            this.labelH6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH5
            // 
            this.labelH5.Location = new System.Drawing.Point(6, 62);
            this.labelH5.Name = "labelH5";
            this.labelH5.Size = new System.Drawing.Size(108, 23);
            this.labelH5.TabIndex = 2;
            this.labelH5.Text = "---";
            this.labelH5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH4
            // 
            this.labelH4.Location = new System.Drawing.Point(6, 39);
            this.labelH4.Name = "labelH4";
            this.labelH4.Size = new System.Drawing.Size(108, 23);
            this.labelH4.TabIndex = 1;
            this.labelH4.Text = "---";
            this.labelH4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH3
            // 
            this.labelH3.Location = new System.Drawing.Point(6, 16);
            this.labelH3.Name = "labelH3";
            this.labelH3.Size = new System.Drawing.Size(108, 23);
            this.labelH3.TabIndex = 0;
            this.labelH3.Text = "---";
            this.labelH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSenhaAtual
            // 
            this.labelSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaAtual.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSenhaAtual.Location = new System.Drawing.Point(12, 40);
            this.labelSenhaAtual.Name = "labelSenhaAtual";
            this.labelSenhaAtual.Size = new System.Drawing.Size(127, 30);
            this.labelSenhaAtual.TabIndex = 3;
            this.labelSenhaAtual.Text = "---";
            this.labelSenhaAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSenha
            // 
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelSenha.Location = new System.Drawing.Point(12, 14);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(127, 23);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha";
            this.labelSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuiche
            // 
            this.labelGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuiche.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelGuiche.Location = new System.Drawing.Point(12, 87);
            this.labelGuiche.Name = "labelGuiche";
            this.labelGuiche.Size = new System.Drawing.Size(127, 23);
            this.labelGuiche.TabIndex = 5;
            this.labelGuiche.Text = "Guichê";
            this.labelGuiche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuicheAtual
            // 
            this.labelGuicheAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuicheAtual.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGuicheAtual.Location = new System.Drawing.Point(12, 110);
            this.labelGuicheAtual.Name = "labelGuicheAtual";
            this.labelGuicheAtual.Size = new System.Drawing.Size(127, 32);
            this.labelGuicheAtual.TabIndex = 6;
            this.labelGuicheAtual.Text = "---";
            this.labelGuicheAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // EmissaoSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 274);
            this.Controls.Add(this.labelGuicheAtual);
            this.Controls.Add(this.labelGuiche);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelSenhaAtual);
            this.Controls.Add(this.historico);
            this.Controls.Add(this.botaoSenhaPreferencial);
            this.Controls.Add(this.botaoSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmissaoSenhas";
            this.Text = "Emissao de Senhas";
            this.historico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoSenha;
        private System.Windows.Forms.Button botaoSenhaPreferencial;
        private System.Windows.Forms.GroupBox historico;
        private System.Windows.Forms.Label labelH8;
        private System.Windows.Forms.Label labelH7;
        private System.Windows.Forms.Label labelH6;
        private System.Windows.Forms.Label labelH5;
        private System.Windows.Forms.Label labelH4;
        private System.Windows.Forms.Label labelH3;
        private System.Windows.Forms.Label labelSenhaAtual;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelGuiche;
        private System.Windows.Forms.Label labelGuicheAtual;
        private System.Windows.Forms.Timer updateTimer;
    }
}