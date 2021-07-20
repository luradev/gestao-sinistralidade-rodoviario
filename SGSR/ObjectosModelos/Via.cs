using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectosModelos
{
    public class Via
    {
        public int IdVia { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Municipio Municipio { get; set; }
    }
}
