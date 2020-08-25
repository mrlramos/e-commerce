using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Contato
    {
        public Contato(string nome, string email, string texto)
        {
            Nome = nome;
            Email = email;
            Texto = texto;
        }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Texto { get; set; }
    }
}
