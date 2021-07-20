using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectosModelos
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string Matricula { get; set; }
        public int Lotacao { get; set; }        
        public Modelo ModeloVeiculo { get; set; }
        public TipoVeiculo Tipo { get; set; }
    }
}
