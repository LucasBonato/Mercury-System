namespace MercuryProject.Forms
{
    partial class FormVeiculos
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
            this.btnCadastrar = new MercuryProject.CustomControls.RoundedButton();
            this.txtBoxDescVeiculo = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxCor = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxMarca = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxModelo = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxChassi = new MercuryProject.CustomControls.RoundedTextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlaca = new MercuryProject.CustomControls.RoundedTextBox();
            this.txtBoxFabricante = new MercuryProject.CustomControls.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // txtBoxDescVeiculo
            // 
            this.txtBoxDescVeiculo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDescVeiculo.BorderColor = System.Drawing.Color.Black;
            this.txtBoxDescVeiculo.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxDescVeiculo.BorderRadius = 5;
            this.txtBoxDescVeiculo.BorderSize = 1;
            this.txtBoxDescVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescVeiculo.Location = new System.Drawing.Point(591, 126);
            this.txtBoxDescVeiculo.Multiline = false;
            this.txtBoxDescVeiculo.Name = "txtBoxDescVeiculo";
            this.txtBoxDescVeiculo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxDescVeiculo.PasswordChar = false;
            this.txtBoxDescVeiculo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxDescVeiculo.PlaceholderText = "Descrição Veículo";
            this.txtBoxDescVeiculo.Size = new System.Drawing.Size(225, 35);
            this.txtBoxDescVeiculo.TabIndex = 48;
            this.txtBoxDescVeiculo.Texts = "";
            this.txtBoxDescVeiculo.UnderlinedStyle = false;
            // 
            // txtBoxCor
            // 
            this.txtBoxCor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCor.BorderColor = System.Drawing.Color.Black;
            this.txtBoxCor.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxCor.BorderRadius = 5;
            this.txtBoxCor.BorderSize = 1;
            this.txtBoxCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCor.Location = new System.Drawing.Point(335, 186);
            this.txtBoxCor.Multiline = false;
            this.txtBoxCor.Name = "txtBoxCor";
            this.txtBoxCor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxCor.PasswordChar = false;
            this.txtBoxCor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxCor.PlaceholderText = "Cor";
            this.txtBoxCor.Size = new System.Drawing.Size(225, 35);
            this.txtBoxCor.TabIndex = 50;
            this.txtBoxCor.Texts = "";
            this.txtBoxCor.UnderlinedStyle = false;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMarca.BorderColor = System.Drawing.Color.Black;
            this.txtBoxMarca.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxMarca.BorderRadius = 5;
            this.txtBoxMarca.BorderSize = 1;
            this.txtBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMarca.Location = new System.Drawing.Point(335, 126);
            this.txtBoxMarca.Multiline = false;
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxMarca.PasswordChar = false;
            this.txtBoxMarca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxMarca.PlaceholderText = "Marca";
            this.txtBoxMarca.Size = new System.Drawing.Size(225, 35);
            this.txtBoxMarca.TabIndex = 47;
            this.txtBoxMarca.Texts = "";
            this.txtBoxMarca.UnderlinedStyle = false;
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxModelo.BorderColor = System.Drawing.Color.Black;
            this.txtBoxModelo.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxModelo.BorderRadius = 5;
            this.txtBoxModelo.BorderSize = 1;
            this.txtBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxModelo.Location = new System.Drawing.Point(85, 186);
            this.txtBoxModelo.Multiline = false;
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxModelo.PasswordChar = false;
            this.txtBoxModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxModelo.PlaceholderText = "Modelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(225, 35);
            this.txtBoxModelo.TabIndex = 49;
            this.txtBoxModelo.Texts = "";
            this.txtBoxModelo.UnderlinedStyle = false;
            // 
            // txtBoxChassi
            // 
            this.txtBoxChassi.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxChassi.BorderColor = System.Drawing.Color.Black;
            this.txtBoxChassi.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxChassi.BorderRadius = 5;
            this.txtBoxChassi.BorderSize = 1;
            this.txtBoxChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxChassi.Location = new System.Drawing.Point(85, 126);
            this.txtBoxChassi.Multiline = false;
            this.txtBoxChassi.Name = "txtBoxChassi";
            this.txtBoxChassi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxChassi.PasswordChar = false;
            this.txtBoxChassi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxChassi.PlaceholderText = "Chassi";
            this.txtBoxChassi.Size = new System.Drawing.Size(225, 35);
            this.txtBoxChassi.TabIndex = 46;
            this.txtBoxChassi.Texts = "";
            this.txtBoxChassi.UnderlinedStyle = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(80, 87);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(242, 30);
            this.lbl.TabIndex = 44;
            this.lbl.Text = "Informações - Veículo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MercuryProject.Properties.Resources.Linha_Divisoo;
            this.pictureBox3.Location = new System.Drawing.Point(79, 307);
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
            // txtBoxPlaca
            // 
            this.txtBoxPlaca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxPlaca.BorderColor = System.Drawing.Color.Black;
            this.txtBoxPlaca.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxPlaca.BorderRadius = 5;
            this.txtBoxPlaca.BorderSize = 1;
            this.txtBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlaca.Location = new System.Drawing.Point(591, 186);
            this.txtBoxPlaca.Multiline = false;
            this.txtBoxPlaca.Name = "txtBoxPlaca";
            this.txtBoxPlaca.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxPlaca.PasswordChar = false;
            this.txtBoxPlaca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxPlaca.PlaceholderText = "Placa";
            this.txtBoxPlaca.Size = new System.Drawing.Size(225, 35);
            this.txtBoxPlaca.TabIndex = 51;
            this.txtBoxPlaca.Texts = "";
            this.txtBoxPlaca.UnderlinedStyle = false;
            // 
            // txtBoxFabricante
            // 
            this.txtBoxFabricante.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxFabricante.BorderColor = System.Drawing.Color.Black;
            this.txtBoxFabricante.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBoxFabricante.BorderRadius = 5;
            this.txtBoxFabricante.BorderSize = 1;
            this.txtBoxFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFabricante.Location = new System.Drawing.Point(85, 246);
            this.txtBoxFabricante.Multiline = false;
            this.txtBoxFabricante.Name = "txtBoxFabricante";
            this.txtBoxFabricante.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBoxFabricante.PasswordChar = false;
            this.txtBoxFabricante.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxFabricante.PlaceholderText = "Fabricante";
            this.txtBoxFabricante.Size = new System.Drawing.Size(225, 35);
            this.txtBoxFabricante.TabIndex = 52;
            this.txtBoxFabricante.Texts = "";
            this.txtBoxFabricante.UnderlinedStyle = false;
            // 
            // FormVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.txtBoxFabricante);
            this.Controls.Add(this.txtBoxPlaca);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxDescVeiculo);
            this.Controls.Add(this.txtBoxCor);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.txtBoxChassi);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVeiculos";
            this.Text = "FormVeiculos";
            this.Load += new System.EventHandler(this.FormVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedButton btnCadastrar;
        private CustomControls.RoundedTextBox txtBoxDescVeiculo;
        private CustomControls.RoundedTextBox txtBoxCor;
        private CustomControls.RoundedTextBox txtBoxMarca;
        private CustomControls.RoundedTextBox txtBoxModelo;
        private CustomControls.RoundedTextBox txtBoxChassi;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedTextBox txtBoxPlaca;
        private CustomControls.RoundedTextBox txtBoxFabricante;
    }
}