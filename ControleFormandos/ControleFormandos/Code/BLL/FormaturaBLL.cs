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
    class FormaturaBLL
    {
        Conexao conect = new Conexao();
        string tabela = "formatura";

        public void Inserir(FormaturaDTO forDTO)
        {
            string inserir = $"insert into {tabela} values(null, '{forDTO.Endereco}', '{forDTO.HorarioInicio}', '{forDTO.DataInicio}')";
            conect.ExecutarComando(inserir);
        }

        public void Alterar(FormaturaDTO forDTO)
        {
            string alterar = $@"update {tabela} set endereco = '{forDTO.Endereco}',
                                horarioInicio ='{forDTO.HorarioInicio}',
                                dataInicio ='{forDTO.DataInicio}' where id ='{forDTO.Id}';";
            conect.ExecutarComando(alterar);
        }

        public void Excluir(FormaturaDTO forDTO)
        {
            string excluir = $"delete from {tabela} where id = {forDTO.Id}";
            conect.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by id";
            return conect.ExecutarConsulta(listar);
        }
    }
}
