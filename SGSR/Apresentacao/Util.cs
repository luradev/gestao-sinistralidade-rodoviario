using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjectosModelos;

namespace Apresentacao
{
    public class Util
    {
        public static string CAMINHO_INICIAL = Application.StartupPath;
        public static string FOTOS_PATH = Application.StartupPath + @"\\Fotos";
        public static string NOME_COMPLETO;

        public static List<Vitima> VITIMAS = new List<Vitima>();

        public static void adicionar_vitima(Vitima vitima)
        {
            VITIMAS.Add(vitima);
        }

        public static void remover_vitima(int indice)
        {
            try
            {
                VITIMAS.RemoveAt(indice);
            }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Seleccione a vítima a ser retirada!"); }
        }

        public static List<Vitima> getVitimas()
        {
            return VITIMAS; 
        }

        public static void reset_lista()
        {
            VITIMAS = new List<Vitima>();
        }

        public static bool existe_foto(string nome)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FOTOS_PATH);
            System.IO.FileInfo[] fi = di.GetFiles();

            foreach (System.IO.FileInfo file in fi)
            {
                if (nome.Contains(file.Name))
                {
                    NOME_COMPLETO = file.FullName;
                    return true;
                }
            }
            return false;
        }

        public static string getNomeCompleto()
        {
            return NOME_COMPLETO;
        }
    }
}
