using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenC_;

namespace ExamenC_
{
    public class EstudiantOrdinari : Estudiant
    {
        //subclase para estudiantes ordinarios
    public EstudiantOrdinari(string nom, int edat, double nota, string classe, string merit)
        :base (nom, edat, nota, classe, merit)
        { 
        
        }
        public override string MostrarDetalls()
        {
            return $"Nom: {Nom} Edat: {Edat} Nota: {Nota} Classe: {Classe}";
        }
    }
}
