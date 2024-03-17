namespace MercuryProject.Forms
{
    partial class FormFuncionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxUF = new MercuryProject.CustomControls.RoundedComboBox();
            this.btnCadastrar = new MercuryProject.CustomControls.RoundedButton();
            this.txtBoxBairro = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxLogradouro = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxNoLogradouro = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxCidade = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxTelefone = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxSenha = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxEmail = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxLogin = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxCPF = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxName = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxCEP = new MercuryProject.CustomControls.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "Endereço - Funcionário\r\n";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(80, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(389, 30);
            this.lbl.TabIndex = 44;
            this.lbl.Text = "Informações pessoais - Funcionário";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = MercuryProject.Properties.Resources.Linha_Divisoo;
            this.pictureBox3.Location = new System.Drawing.Point(79, 273);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(737, 2);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MercuryProject.Properties.Resources.Linha_vermelha;
            this.pictureBox2.Location = new System.Drawing.Point(12, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 7);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MercuryProject.Properties.Resources.Linha_vermelha;
            this.pictureBox1.Location = new System.Drawing.Point(703, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 7);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Audiowide", 24F);
            this.label1.Location = new System.Drawing.Point(195, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 41);
            this.label1.TabIndex = 40;
            this.label1.Text = "Informações Para Cadastro";
            // 
            // cmbBoxUF
            // 
            this.cmbBoxUF.BackColor = System.Drawing.Color.White;
            this.cmbBoxUF.BorderColor = System.Drawing.Color.Black;
            this.cmbBoxUF.BorderSize = 1;
            this.cmbBoxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBoxUF.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBoxUF.IconColor = System.Drawing.Color.Black;
            this.cmbBoxUF.IsPlaceholder = false;
            this.cmbBoxUF.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "AC",
            "MA"});
            this.cmbBoxUF.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbBoxUF.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbBoxUF.Location = new System.Drawing.Point(85, 340);
            this.cmbBoxUF.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbBoxUF.Name = "cmbBoxUF";
            this.cmbBoxUF.Padding = new System.Windows.Forms.Padding(1);
            this.cmbBoxUF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cmbBoxUF.PlaceholderText = "";
            this.cmbBoxUF.Size = new System.Drawing.Size(225, 35);
            this.cmbBoxUF.TabIndex = 52;
            this.cmbBoxUF.Texts = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnCadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnCadastrar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BorderRadius = 10;
            this.btnCadastrar.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(678, 516);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 57);
            this.btnCadastrar.TabIndex = 57;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextColor = System.Drawing.Color.White;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxBairro.BorderColor = System.Drawing.Color.Black;
            this.txtBoxBairro.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxBairro.BorderRadius = 5;
            this.txtBoxBairro.BorderSize = 1;
            this.txtBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBairro.Location = new System.Drawing.Point(591, 340);
            this.txtBoxBairro.Multiline = false;
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxBairro.PasswordChar = false;
            this.txtBoxBairro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxBairro.PlaceholderText = "Bairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(225, 35);
            this.txtBoxBairro.TabIndex = 54;
            this.txtBoxBairro.Texts = "";
            this.txtBoxBairro.UnderlinedStyle = false;
            // 
            // txtBoxLogradouro
            // 
            this.txtBoxLogradouro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxLogradouro.BorderColor = System.Drawing.Color.Black;
            this.txtBoxLogradouro.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxLogradouro.BorderRadius = 5;
            this.txtBoxLogradouro.BorderSize = 1;
            this.txtBoxLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogradouro.Location = new System.Drawing.Point(85, 400);
            this.txtBoxLogradouro.Multiline = false;
            this.txtBoxLogradouro.Name = "txtBoxLogradouro";
            this.txtBoxLogradouro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxLogradouro.PasswordChar = false;
            this.txtBoxLogradouro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxLogradouro.PlaceholderText = "Logradouro";
            this.txtBoxLogradouro.Size = new System.Drawing.Size(225, 35);
            this.txtBoxLogradouro.TabIndex = 55;
            this.txtBoxLogradouro.Texts = "";
            this.txtBoxLogradouro.UnderlinedStyle = false;
            // 
            // txtBoxNoLogradouro
            // 
            this.txtBoxNoLogradouro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNoLogradouro.BorderColor = System.Drawing.Color.Black;
            this.txtBoxNoLogradouro.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxNoLogradouro.BorderRadius = 5;
            this.txtBoxNoLogradouro.BorderSize = 1;
            this.txtBoxNoLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNoLogradouro.Location = new System.Drawing.Point(335, 400);
            this.txtBoxNoLogradouro.Multiline = false;
            this.txtBoxNoLogradouro.Name = "txtBoxNoLogradouro";
            this.txtBoxNoLogradouro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxNoLogradouro.PasswordChar = false;
            this.txtBoxNoLogradouro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxNoLogradouro.PlaceholderText = "Número logradouro";
            this.txtBoxNoLogradouro.Size = new System.Drawing.Size(225, 35);
            this.txtBoxNoLogradouro.TabIndex = 56;
            this.txtBoxNoLogradouro.Texts = "";
            this.txtBoxNoLogradouro.UnderlinedStyle = false;
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCidade.BorderColor = System.Drawing.Color.Black;
            this.txtBoxCidade.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxCidade.BorderRadius = 5;
            this.txtBoxCidade.BorderSize = 1;
            this.txtBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCidade.Location = new System.Drawing.Point(335, 340);
            this.txtBoxCidade.Multiline = false;
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxCidade.PasswordChar = false;
            this.txtBoxCidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxCidade.PlaceholderText = "Cidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(225, 35);
            this.txtBoxCidade.TabIndex = 53;
            this.txtBoxCidade.Texts = "";
            this.txtBoxCidade.UnderlinedStyle = false;
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTelefone.BorderColor = System.Drawing.Color.Black;
            this.txtBoxTelefone.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxTelefone.BorderRadius = 5;
            this.txtBoxTelefone.BorderSize = 1;
            this.txtBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefone.Location = new System.Drawing.Point(335, 123);
            this.txtBoxTelefone.Multiline = false;
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxTelefone.PasswordChar = false;
            this.txtBoxTelefone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxTelefone.PlaceholderText = "Telefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(225, 35);
            this.txtBoxTelefone.TabIndex = 47;
            this.txtBoxTelefone.Texts = "";
            this.txtBoxTelefone.UnderlinedStyle = false;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSenha.BorderColor = System.Drawing.Color.Black;
            this.txtBoxSenha.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxSenha.BorderRadius = 5;
            this.txtBoxSenha.BorderSize = 1;
            this.txtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(591, 183);
            this.txtBoxSenha.Multiline = false;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxSenha.PasswordChar = false;
            this.txtBoxSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxSenha.PlaceholderText = "Senha";
            this.txtBoxSenha.Size = new System.Drawing.Size(225, 35);
            this.txtBoxSenha.TabIndex = 51;
            this.txtBoxSenha.Texts = "";
            this.txtBoxSenha.UnderlinedStyle = false;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxEmail.BorderColor = System.Drawing.Color.Black;
            this.txtBoxEmail.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxEmail.BorderRadius = 5;
            this.txtBoxEmail.BorderSize = 1;
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(335, 183);
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxEmail.PasswordChar = false;
            this.txtBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxEmail.PlaceholderText = "Email";
            this.txtBoxEmail.Size = new System.Drawing.Size(225, 35);
            this.txtBoxEmail.TabIndex = 50;
            this.txtBoxEmail.Texts = "";
            this.txtBoxEmail.UnderlinedStyle = false;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxLogin.BorderColor = System.Drawing.Color.Black;
            this.txtBoxLogin.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxLogin.BorderRadius = 5;
            this.txtBoxLogin.BorderSize = 1;
            this.txtBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogin.Location = new System.Drawing.Point(591, 123);
            this.txtBoxLogin.Multiline = false;
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxLogin.PasswordChar = false;
            this.txtBoxLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxLogin.PlaceholderText = "Login";
            this.txtBoxLogin.Size = new System.Drawing.Size(225, 35);
            this.txtBoxLogin.TabIndex = 48;
            this.txtBoxLogin.Texts = "";
            this.txtBoxLogin.UnderlinedStyle = false;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCPF.BorderColor = System.Drawing.Color.Black;
            this.txtBoxCPF.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxCPF.BorderRadius = 5;
            this.txtBoxCPF.BorderSize = 1;
            this.txtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPF.Location = new System.Drawing.Point(85, 183);
            this.txtBoxCPF.Multiline = false;
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxCPF.PasswordChar = false;
            this.txtBoxCPF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxCPF.PlaceholderText = "CPF/CNPJ";
            this.txtBoxCPF.Size = new System.Drawing.Size(225, 35);
            this.txtBoxCPF.TabIndex = 49;
            this.txtBoxCPF.Texts = "";
            this.txtBoxCPF.UnderlinedStyle = false;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxName.BorderColor = System.Drawing.Color.Black;
            this.txtBoxName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxName.BorderRadius = 5;
            this.txtBoxName.BorderSize = 1;
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(85, 123);
            this.txtBoxName.Multiline = false;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxName.PasswordChar = false;
            this.txtBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxName.PlaceholderText = "Nome Completo";
            this.txtBoxName.Size = new System.Drawing.Size(225, 35);
            this.txtBoxName.TabIndex = 46;
            this.txtBoxName.Texts = "";
            this.txtBoxName.UnderlinedStyle = false;
            // 
            // txtBoxCEP
            // 
            this.txtBoxCEP.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCEP.BorderColor = System.Drawing.Color.Black;
            this.txtBoxCEP.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxCEP.BorderRadius = 5;
            this.txtBoxCEP.BorderSize = 1;
            this.txtBoxCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCEP.Location = new System.Drawing.Point(591, 400);
            this.txtBoxCEP.Multiline = false;
            this.txtBoxCEP.Name = "txtBoxCEP";
            this.txtBoxCEP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxCEP.PasswordChar = false;
            this.txtBoxCEP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxCEP.PlaceholderText = "CEP";
            this.txtBoxCEP.Size = new System.Drawing.Size(225, 35);
            this.txtBoxCEP.TabIndex = 57;
            this.txtBoxCEP.Texts = "";
            this.txtBoxCEP.UnderlinedStyle = false;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.txtBoxCEP);
            this.Controls.Add(this.cmbBoxUF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxBairro);
            this.Controls.Add(this.txtBoxLogradouro);
            this.Controls.Add(this.txtBoxNoLogradouro);
            this.Controls.Add(this.txtBoxCidade);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.txtBoxCPF);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionario";
            this.Text = "FormFuncionario";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedComboBox cmbBoxUF;
        private CustomControls.RoundedButton btnCadastrar;
        private CustomControls.RoundedTextBox txtBoxBairro;
        private CustomControls.RoundedTextBox txtBoxLogradouro;
        private CustomControls.RoundedTextBox txtBoxNoLogradouro;
        private CustomControls.RoundedTextBox txtBoxCidade;
        private CustomControls.RoundedTextBox txtBoxTelefone;
        private CustomControls.RoundedTextBox txtBoxSenha;
        private CustomControls.RoundedTextBox txtBoxEmail;
        private CustomControls.RoundedTextBox txtBoxLogin;
        private CustomControls.RoundedTextBox txtBoxCPF;
        private CustomControls.RoundedTextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedTextBox txtBoxCEP;
    }
}