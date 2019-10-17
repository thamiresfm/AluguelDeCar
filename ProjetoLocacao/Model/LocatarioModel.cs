using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    class LocatarioModel
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime Nasc {get; set;}
        public bool Fumante { get; set; }
        public string Sexo { get; set; }

    }
}
