using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFormandos.Code.DTO
{
    class FormandoDTO
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _telefone;
        private int _formaturaId;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public int FormaturaId { get => _formaturaId; set => _formaturaId = value; }
    }
}
