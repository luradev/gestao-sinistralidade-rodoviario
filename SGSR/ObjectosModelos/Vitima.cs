using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectosModelos;

namespace ObjectosModelos
{
    public class Vitima
    {
        public int IdVitima { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public Acidente Acidente { get; set; }
    }
}
