
namespace ControleFormandos.Ui
{
    partial class FrmFormatura
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
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.dtDataFormatura = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgFormaturas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(12, 152);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 39;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(136, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(285, 20);
            this.txtEndereco.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Location = new System.Drawing.Point(12, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 57);
            this.panel1.TabIndex = 37;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(308, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 30);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(108, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 30);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(8, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(208, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 30);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(9, 130);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(89, 13);
            this.lblHorario.TabIndex = 36;
            this.lblHorario.Text = "Horário de Início:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(133, 66);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 35;
            this.lblEndereco.Text = "Endereço:";
            // 
            // dtDataFormatura
            // 
            this.dtDataFormatura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFormatura.Location = new System.Drawing.Point(136, 152);
            this.dtDataFormatura.Name = "dtDataFormatura";
            this.dtDataFormatura.Size = new System.Drawing.Size(285, 20);
            this.dtDataFormatura.TabIndex = 33;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 32;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 66);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 31;
            this.lblCodigo.Text = "Código:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(133, 130);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 30;
            this.lblData.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Controle de Formaturas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgFormaturas
            // 
            this.dtgFormaturas.BackgroundColor = System.Drawing.Color.White;
            this.dtgFormaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFormaturas.Location = new System.Drawing.Point(12, 277);
            this.dtgFormaturas.Name = "dtgFormaturas";
            this.dtgFormaturas.Size = new System.Drawing.Size(410, 150);
            this.dtgFormaturas.TabIndex = 41;
            this.dtgFormaturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFormaturas_CellClick);
            // 
            // FrmFormatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 439);
            this.Controls.Add(this.dtgFormaturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.dtDataFormatura);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblData);
            this.Name = "FrmFormatura";
            this.Text = "FrmFormatura";
            this.Load += new System.EventHandler(this.FrmFormatura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.DateTimePicker dtDataFormatura;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgFormaturas;
    }
}