namespace PocketQueue
{
    partial class PainelAdministracao
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
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.botaoRelatorios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(12, 12);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(166, 23);
            this.botaoCadastro.TabIndex = 0;
            this.botaoCadastro.Text = "Cadastro de Funcionários";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            // 
            // botaoRelatorios
            // 
            this.botaoRelatorios.Location = new System.Drawing.Point(12, 41);
            this.botaoRelatorios.Name = "botaoRelatorios";
            this.botaoRelatorios.Size = new System.Drawing.Size(166, 23);
            this.botaoRelatorios.TabIndex = 1;
            this.botaoRelatorios.Text = "button2";
            this.botaoRelatorios.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PainelAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.botaoRelatorios);
            this.Controls.Add(this.botaoCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PainelAdministracao";
            this.Text = "Painel de Administracao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.Button botaoRelatorios;
        private System.Windows.Forms.Button button3;
    }
}