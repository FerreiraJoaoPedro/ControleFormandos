
namespace ControleFormandos
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFormandos = new System.Windows.Forms.Button();
            this.btnFormaturas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormandos
            // 
            this.btnFormandos.Location = new System.Drawing.Point(58, 51);
            this.btnFormandos.Name = "btnFormandos";
            this.btnFormandos.Size = new System.Drawing.Size(176, 23);
            this.btnFormandos.TabIndex = 0;
            this.btnFormandos.Text = "GERENCIAR FORMANDOS";
            this.btnFormandos.UseVisualStyleBackColor = true;
            this.btnFormandos.Click += new System.EventHandler(this.btnFormandos_Click);
            // 
            // btnFormaturas
            // 
            this.btnFormaturas.Location = new System.Drawing.Point(58, 91);
            this.btnFormaturas.Name = "btnFormaturas";
            this.btnFormaturas.Size = new System.Drawing.Size(176, 23);
            this.btnFormaturas.TabIndex = 1;
            this.btnFormaturas.Text = "GERENCIAR FORMATURAS";
            this.btnFormaturas.UseVisualStyleBackColor = true;
            this.btnFormaturas.Click += new System.EventHandler(this.btnFormaturas_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(58, 131);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 203);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFormaturas);
            this.Controls.Add(this.btnFormandos);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormandos;
        private System.Windows.Forms.Button btnFormaturas;
        private System.Windows.Forms.Button btnSair;
    }
}

