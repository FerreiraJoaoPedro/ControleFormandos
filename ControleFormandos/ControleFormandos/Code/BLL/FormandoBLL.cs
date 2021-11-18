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
    class FormandoBLL
    {

        Conexao conect = new Conexao();
        string tabela = "formando";

        public void Inserir(FormandoDTO forDTO)
        {
            string inserir = $"insert into {tabela} values(null, '{forDTO.Nome}', '{forDTO.Email}', '{forDTO.Telefone}', '{forDTO.FormaturaId}')";
            conect.ExecutarComando(inserir);
        }

        public void Alterar(FormandoDTO forDTO)
        {
            string alterar = $@"update {tabela} set nome = '{forDTO.Nome}',
                                email ='{forDTO.Email}',
                                telefone ='{forDTO.Telefone}' where id ='{forDTO.Id}';";
            conect.ExecutarComando(alterar);
        }

        public void Excluir(FormandoDTO forDTO)
        {
            string excluir = $"delete from {tabela} where id = {forDTO.Id}";
            conect.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select {tabela}.*, formatura.endereco as endereço from {tabela} join formatura on formatura.id = {tabela}.formatura_id order by id";
            return conect.ExecutarConsulta(listar);
        }
    }
}
