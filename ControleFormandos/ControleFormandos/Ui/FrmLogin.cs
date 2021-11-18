using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFormandos.Code.BLL;
using ControleFormandos.Code.DTO;
using System.Net;
using System.Net.Mail;

namespace ControleFormandos.Ui
{
    public partial class FrmLogin : Form
    {
        UsuarioBLL loginBLL = new UsuarioBLL();
        UsuarioDTO loginDTO = new UsuarioDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if(loginBLL.RealizarLogin(loginDTO) == true)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }

        private void lnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("11901420@aluno.cotemig.com.br", "mkqmxdpvhfunzonl"),
                EnableSsl = true
            };

            loginDTO.Email = txtEmail.Text;
            dtBuscarSenha.DataSource = loginBLL.BuscarSenha(loginDTO);
            if(dtBuscarSenha.Rows.Count > 1)
            {
                string email = dtBuscarSenha.Rows[0].Cells[2].Value.ToString();
                string senha = dtBuscarSenha.Rows[0].Cells[3].Value.ToString();

                client.Send("11901420@aluno.cotemig.com.br", email, "Recuperação de senha", "Sua senha é" + senha);
                MessageBox.Show("Email enviado para: " + email);
            }
            else
            {
                MessageBox.Show("Esse email não está cadastrado no sistema");
            }
           


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            dtBuscarSenha.Visible = false;
        }
    }
}
