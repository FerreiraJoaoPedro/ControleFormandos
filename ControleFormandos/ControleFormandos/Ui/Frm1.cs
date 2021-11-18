using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFormandos.Ui;

namespace ControleFormandos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFormandos_Click(object sender, EventArgs e)
        {
            FrmFormando Formando = new FrmFormando();
            Formando.ShowDialog();
        }

        private void btnFormaturas_Click(object sender, EventArgs e)
        {
            FrmFormatura Formatura = new FrmFormatura();
            Formatura.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
