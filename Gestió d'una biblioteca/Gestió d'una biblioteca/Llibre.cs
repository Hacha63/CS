using System;
using Gestió_d_una_biblioteca;

namespace Gestió_d_una_biblioteca
{
    public abstract class Llibre
    {
        public string Titol { get; set; }
        public string Autor { get; set; }
        public int Any { get; set; }
        public string ISBN { get; set; }

        public Llibre (string titol, string autor, int any, string isbn)
        {
            Titol = titol;
            Autor = autor;
            Any = any;
            ISBN = isbn;
        }

        public abstract string MostrarInformacio();
        
    }
}