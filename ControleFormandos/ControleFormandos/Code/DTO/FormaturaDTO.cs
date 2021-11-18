using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFormandos.Code.DTO
{
    class FormaturaDTO
    {
        private int _id;
        private string _endereco;
        private string _horarioInicio;
        private string dataInicio;

        public int Id { get => _id; set => _id = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string HorarioInicio { get => _horarioInicio; set => _horarioInicio = value; }
        public string DataInicio { get => dataInicio; set => dataInicio = value; }
    }
}
