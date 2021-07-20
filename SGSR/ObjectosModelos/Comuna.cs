using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectosModelos
{
    public class Comuna
    {
        public int IdComuna { get; set; }
        public string Nome { get; set; }
        public Municipio Municipio { get; set; }

    }
}
