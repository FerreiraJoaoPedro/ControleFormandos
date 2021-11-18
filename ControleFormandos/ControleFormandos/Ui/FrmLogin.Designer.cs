
namespace ControleFormandos.Ui
{
    partial class FrmLogin
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lnkLabEsqueceu = new System.Windows.Forms.LinkLabel();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.dtBuscarSenha = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuscarSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(46, 269);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(216, 23);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(43, 196);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(46, 212);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(216, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(46, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lnkLabEsqueceu
            // 
            this.lnkLabEsqueceu.AutoSize = true;
            this.lnkLabEsqueceu.Location = new System.Drawing.Point(100, 312);
            this.lnkLabEsqueceu.Name = "lnkLabEsqueceu";
            this.lnkLabEsqueceu.Size = new System.Drawing.Size(113, 13);
            this.lnkLabEsqueceu.TabIndex = 6;
            this.lnkLabEsqueceu.TabStop = true;
            this.lnkLabEsqueceu.Text = "Esqueceu sua senha?";
            this.lnkLabEsqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabEsqueceu_LinkClicked);
            // 
            // picLogin
            // 
            this.picLogin.Image = global::ControleFormandos.Properties.Resources.login1;
            this.picLogin.Location = new System.Drawing.Point(96, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(117, 108);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 3;
            this.picLogin.TabStop = false;
            // 
            // dtBuscarSenha
            // 
            this.dtBuscarSenha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBuscarSenha.Location = new System.Drawing.Point(31, 356);
            this.dtBuscarSenha.Name = "dtBuscarSenha";
            this.dtBuscarSenha.Size = new System.Drawing.Size(240, 150);
            this.dtBuscarSenha.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 518);
            this.Controls.Add(this.dtBuscarSenha);
            this.Controls.Add(this.lnkLabEsqueceu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnEntrar);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuscarSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.LinkLabel lnkLabEsqueceu;
        private System.Windows.Forms.DataGridView dtBuscarSenha;
    }
}