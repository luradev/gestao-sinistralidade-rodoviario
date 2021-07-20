using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectosModelos
{
    public class Acidente
    {
        public int IdAcidente { get; set; }
        public DateTime DataAcidente { get; set; }
        public string Periodo { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public Via Via { get; set; }
        public Veiculo Veiculo { get; set; }
        public Condutor Condutor { get; set; }
        public ClassificacaoAcidente Classificacao { get; set; }
    }
}
