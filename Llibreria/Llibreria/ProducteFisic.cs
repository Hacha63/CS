using Llibreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProducteFisic : Producte
{
    public float Pes { get; set; }

    public ProducteFisic(string nom, decimal preu, float pes)
        : base(nom, preu)
    {
        Pes = pes;
    }

    public override string MostrarDetalls()
    {
        return $"{Nom} (Físic) - Preu: {Preu:C}, Pes: {Pes} kg";
    }
}
