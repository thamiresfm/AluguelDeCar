using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    class CarroModel
    {
        public int IdCarro { get; set; }
        public string NumPlaca { get; set; }
        public bool TemAr { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set;}
        public int QtdPorta { get; set;}
        public int IdTabela { get; set; }
    
    }
}
