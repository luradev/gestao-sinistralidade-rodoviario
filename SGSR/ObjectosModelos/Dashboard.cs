using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ObjectosModelos
{
    public class Dashboard
    {
        ArrayList vias = new ArrayList();

        public ArrayList Vias
        {
            get { return vias; }
            set { vias = value; }
        }

        ArrayList v_QtdAcidente = new ArrayList();

        public ArrayList V_QtdAcidente
        {
            get { return v_QtdAcidente; }
            set { v_QtdAcidente = value; }
        }

        ArrayList c_QtdAcidente = new ArrayList();

        public ArrayList C_QtdAcidente
        {
            get { return c_QtdAcidente; }
            set { c_QtdAcidente = value; }
        }
        ArrayList municipio = new ArrayList();

        public ArrayList Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }
        ArrayList qtdAcidente = new ArrayList();

        public ArrayList QtdAcidente
        {
            get { return qtdAcidente; }
            set { qtdAcidente = value; }
        }
        ArrayList classificacao = new ArrayList();

        public ArrayList Classificacao
        {
            get { return classificacao; }
            set { classificacao = value; }
        }
    }
}
