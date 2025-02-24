using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenC_;

namespace ExamenC_
{
    //subclase para estudiantes excelentes
    public class EstudiantExcel_lent : Estudiant
    {
        public string merit;
        
        public EstudiantExcel_lent(string nom, int edat, double nota, string classe, string merit)
        : base(nom, edat, nota, classe, merit)
        {

        }
        public override string MostrarDetalls()
        {
            return $"Nom: {Nom} Edat: {Edat} Nota: {Nota} Classe: {Classe} Mèrit: {merit}";
        }
    }
}
