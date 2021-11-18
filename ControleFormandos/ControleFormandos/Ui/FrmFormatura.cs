using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFormandos.Code.DTO;
using ControleFormandos.Code.BLL;

namespace ControleFormandos.Ui
{
    public partial class FrmFormatura : Form
    {
        FormaturaBLL forBLL = new FormaturaBLL();
        FormaturaDTO forDTO = new FormaturaDTO();
        public FrmFormatura()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            forDTO.Endereco = txtEndereco.Text;
            forDTO.DataInicio = dtDataFormatura.Text;
            forDTO.HorarioInicio = txtHorario.Text;

            forBLL.Inserir(forDTO);

            MessageBox.Show("Cadastro efetuado com sucesso!", "Formatura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();
            txtEndereco.Clear();
            txtHorario.Clear();

            dtgFormaturas.DataSource = forBLL.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            forDTO.Id = int.Parse(txtCodigo.Text);
            forDTO.Endereco = txtEndereco.Text;
            forDTO.DataInicio = dtDataFormatura.Text;
            forDTO.HorarioInicio = txtHorario.Text;

            forBLL.Alterar(forDTO);

            MessageBox.Show("Cadastro alterado com sucesso!", "Formatura", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtCodigo.Clear();
            txtEndereco.Clear();
            txtHorario.Clear();

            dtgFormaturas.DataSource = forBLL.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            forDTO.Id = int.Parse(txtCodigo.Text);

            forBLL.Excluir(forDTO);

            MessageBox.Show("Cadastro excluído com sucesso!", "Formatura", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtCodigo.Clear();

            dtgFormaturas.DataSource = forBLL.Listar();
        }

        private void FrmFormatura_Load(object sender, EventArgs e)
        {
            dtgFormaturas.DataSource = forBLL.Listar();
        }

        private void dtgFormaturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txtCodigo.Text = dtgFormaturas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEndereco.Text = dtgFormaturas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHorario.Text = dtgFormaturas.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
