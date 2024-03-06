namespace MercuryProject
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.picBoxEye = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogar = new MercuryProject.CustomControls.RoundedButton();
            this.txtBoxSenha = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxLogin = new MercuryProject.CustomControls.RoundedTextBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Audiowide", 24F);
            this.label1.Location = new System.Drawing.Point(117, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.Controls.Add(this.btnSair);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(350, 30);
            this.panelControl.TabIndex = 6;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(320, 0);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(190, 446);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 29);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // picBoxEye
            // 
            this.picBoxEye.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxEye.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxEye.Image = global::MercuryProject.Properties.Resources.hide;
            this.picBoxEye.Location = new System.Drawing.Point(260, 270);
            this.picBoxEye.Name = "picBoxEye";
            this.picBoxEye.Size = new System.Drawing.Size(40, 40);
            this.picBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxEye.TabIndex = 11;
            this.picBoxEye.TabStop = false;
            this.picBoxEye.Click += new System.EventHandler(this.picBoxEye_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MercuryProject.Properties.Resources.Linha_vermelha;
            this.pictureBox2.Location = new System.Drawing.Point(12, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 7);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MercuryProject.Properties.Resources.Linha_vermelha;
            this.pictureBox1.Location = new System.Drawing.Point(238, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 7);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnLogar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnLogar.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogar.BorderRadius = 5;
            this.btnLogar.BorderSize = 0;
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(50, 370);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(250, 40);
            this.btnLogar.TabIndex = 9;
            this.btnLogar.Text = "Logar";
            this.btnLogar.TextColor = System.Drawing.Color.White;
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSenha.BorderColor = System.Drawing.Color.Black;
            this.txtBoxSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.txtBoxSenha.BorderRadius = 10;
            this.txtBoxSenha.BorderSize = 2;
            this.txtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(50, 270);
            this.txtBoxSenha.Multiline = false;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxSenha.PasswordChar = true;
            this.txtBoxSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxSenha.PlaceholderText = "Senha";
            this.txtBoxSenha.Size = new System.Drawing.Size(208, 40);
            this.txtBoxSenha.TabIndex = 8;
            this.txtBoxSenha.Texts = "";
            this.txtBoxSenha.UnderlinedStyle = false;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxLogin.BorderColor = System.Drawing.Color.Black;
            this.txtBoxLogin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.txtBoxLogin.BorderRadius = 10;
            this.txtBoxLogin.BorderSize = 2;
            this.txtBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogin.Location = new System.Drawing.Point(50, 170);
            this.txtBoxLogin.Multiline = false;
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxLogin.PasswordChar = false;
            this.txtBoxLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxLogin.PlaceholderText = "Login";
            this.txtBoxLogin.Size = new System.Drawing.Size(250, 40);
            this.txtBoxLogin.TabIndex = 7;
            this.txtBoxLogin.Texts = "";
            this.txtBoxLogin.UnderlinedStyle = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.picBoxEye);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnSair;
        private CustomControls.RoundedTextBox txtBoxLogin;
        private CustomControls.RoundedTextBox txtBoxSenha;
        private CustomControls.RoundedButton btnLogar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox picBoxEye;
    }
}