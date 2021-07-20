using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectosModelos
{
    public class Municipio
    {
        public int IdMunicipio { get; set; }
        public string Nome { get; set; }
        public Provincia Provincia { get; set; }
    }
}
