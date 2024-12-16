using System;
using Gestió_d_una_biblioteca;


public class LlibreDigital : Llibre
{
    public LlibreDigital(string titol, string autor, int any, string isbn)
    : base(titol, autor, any, isbn)
    {

    }

    public override string MostrarInformacio()
    {
        return $"Titol: {Titol}, Tipus: Digital";
    }
}