using System;
using Gestió_d_una_biblioteca;


public class LlibrePaper : Llibre
{
    public LlibrePaper(string titol, string autor, int any, string isbn)
        : base(titol, autor, any, isbn)
    {

    }
    public override string MostrarInformacio()
    {
        return $"Titol : {Titol} Tipus: Paper";
    }
}