using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFormandos.Code.DTO;
using ControleFormandos.Code.DAL;
using System.Data;

namespace ControleFormandos.Code.BLL
{
    class UsuarioBLL
    {
        Conexao conect = new Conexao();
        string tabela = "usuario";

        public bool RealizarLogin(UsuarioDTO login)
        {
            string sql = $"select * from {tabela} where email ='{login.Email}' and senha ='{login.Senha}'";
            DataTable dt = conect.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public DataTable BuscarSenha(UsuarioDTO login)
        {
            string buscar = $"select * from {tabela} where email ='{login.Email}'";
            return conect.ExecutarConsulta(buscar);
        }
    }
}
