using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Llibreria
{
    

    public abstract class Producte
    {
        public string Nom { get; set; }
        public decimal Preu { get; set; }
       
        public Producte (string nom, decimal preu)
        {
            Nom = nom;
            Preu = preu;
        }
        public abstract string MostrarDetalls();
    }

}
