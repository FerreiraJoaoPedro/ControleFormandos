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
    public partial class FrmFormando : Form
    {
        FormandoBLL forBLL = new FormandoBLL();
        FormandoDTO forDTO = new FormandoDTO();
        FormaturaDTO maturaDTO = new FormaturaDTO();
        FormaturaBLL maturaBLL = new FormaturaBLL();

        public FrmFormando()
        {
            InitializeComponent();
        }

        private void FrmFormando_Load(object sender, EventArgs e)
        {
            cbxFormaturas.DataSource = maturaBLL.Listar();
            cbxFormaturas.ValueMember = "Id";
            cbxFormaturas.DisplayMember = "Endereco";
            dtgFormandos.DataSource = forBLL.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            forDTO.Nome = txtNome.Text;
            forDTO.Email = txtEmail.Text;
            forDTO.Telefone = txtTelefone.Text;
            forDTO.FormaturaId = Convert.ToInt32(cbxFormaturas.SelectedValue);

            forBLL.Inserir(forDTO);

            MessageBox.Show("Cadastro efetuado com sucesso!", "Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            cbxFormaturas.SelectedIndex = 0;

            dtgFormandos.DataSource = forBLL.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            forDTO.Id = int.Parse(txtCodigo.Text);
            forDTO.Nome = txtNome.Text;
            forDTO.Email = txtEmail.Text;
            forDTO.Telefone = txtTelefone.Text;
            forDTO.FormaturaId = Convert.ToInt32(cbxFormaturas.SelectedValue);

            forBLL.Alterar(forDTO);

            MessageBox.Show("Cadastro alterado com sucesso!", "Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            cbxFormaturas.SelectedIndex = 0;

            dtgFormandos.DataSource = forBLL.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            forDTO.Id = int.Parse(txtCodigo.Text);
            forDTO.Nome = txtNome.Text;

            forBLL.Excluir(forDTO);

            MessageBox.Show("Cadastro excluído com sucesso!", "Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();

            dtgFormandos.DataSource = forBLL.Listar();
        }

        private void dtgFormandos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgFormandos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgFormandos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dtgFormandos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = dtgFormandos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
