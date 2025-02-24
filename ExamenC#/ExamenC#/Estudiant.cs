using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_
{
        //Clase padre Estudiant con sus atributos
    public abstract class Estudiant
    {
        public string Nom {  get; set; }
        public int Edat { get; set; }
        public double Nota { get; set; }
        public string Classe { get; set; }
        public string Merit { get; set; }

        public Estudiant(string nom, int edat, double nota, string classe, string merit) 
        { 
            Nom = nom;
            Edat = edat;
            Nota = nota;
            Classe = classe;
            Merit = merit;
        }

        public abstract string MostrarDetalls();
    }
}
