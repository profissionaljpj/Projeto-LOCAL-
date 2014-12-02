namespace PocketQueue
{
    partial class TelaCadastroUsuario
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
            this.Cadastrar_button = new System.Windows.Forms.Button();
            this.Cancelar_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpfTBox = new System.Windows.Forms.TextBox();
            this.nomeTBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loginTBox = new System.Windows.Forms.TextBox();
            this.senhaTBox = new System.Windows.Forms.TextBox();
            this.tipoCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cadastrar_button
            // 
            this.Cadastrar_button.Location = new System.Drawing.Point(110, 201);
            this.Cadastrar_button.Name = "Cadastrar_button";
            this.Cadastrar_button.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar_button.TabIndex = 12;
            this.Cadastrar_button.Text = "Cadastrar";
            this.Cadastrar_button.UseVisualStyleBackColor = true;
            this.Cadastrar_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar_button
            // 
            this.Cancelar_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar_button.Location = new System.Drawing.Point(249, 201);
            this.Cancelar_button.Name = "Cancelar_button";
            this.Cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_button.TabIndex = 13;
            this.Cancelar_button.Text = "Cancelar";
            this.Cancelar_button.UseVisualStyleBackColor = true;
            this.Cancelar_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cpfTBox);
            this.groupBox1.Controls.Add(this.nomeTBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 61);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cpf:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome:";
            // 
            // cpfTBox
            // 
            this.cpfTBox.Location = new System.Drawing.Point(228, 25);
            this.cpfTBox.Name = "cpfTBox";
            this.cpfTBox.Size = new System.Drawing.Size(176, 20);
            this.cpfTBox.TabIndex = 3;
            // 
            // nomeTBox
            // 
            this.nomeTBox.Location = new System.Drawing.Point(45, 25);
            this.nomeTBox.Name = "nomeTBox";
            this.nomeTBox.Size = new System.Drawing.Size(126, 20);
            this.nomeTBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tipoCBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.loginTBox);
            this.groupBox2.Controls.Add(this.senhaTBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 105);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cadastrais";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Login:";
            // 
            // loginTBox
            // 
            this.loginTBox.Location = new System.Drawing.Point(111, 19);
            this.loginTBox.Name = "loginTBox";
            this.loginTBox.Size = new System.Drawing.Size(293, 20);
            this.loginTBox.TabIndex = 8;
            this.loginTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // senhaTBox
            // 
            this.senhaTBox.Location = new System.Drawing.Point(111, 45);
            this.senhaTBox.Name = "senhaTBox";
            this.senhaTBox.Size = new System.Drawing.Size(293, 20);
            this.senhaTBox.TabIndex = 9;
            this.senhaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senhaTBox.UseSystemPasswordChar = true;
            // 
            // tipoCBox
            // 
            this.tipoCBox.FormattingEnabled = true;
            this.tipoCBox.Items.AddRange(new object[] {
            "Atendente",
            "Gerente",
            "Monitor"});
            this.tipoCBox.Location = new System.Drawing.Point(111, 71);
            this.tipoCBox.Name = "tipoCBox";
            this.tipoCBox.Size = new System.Drawing.Size(121, 21);
            this.tipoCBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tipo de Usuario:";
            // 
            // TelaCadastroUsuario
            // 
            this.AcceptButton = this.Cadastrar_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.Cancelar_button;
            this.ClientSize = new System.Drawing.Size(434, 234);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancelar_button);
            this.Controls.Add(this.Cadastrar_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novo Usuário";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar_button;
        private System.Windows.Forms.Button Cancelar_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpfTBox;
        private System.Windows.Forms.TextBox nomeTBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loginTBox;
        private System.Windows.Forms.TextBox senhaTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipoCBox;

    }
}