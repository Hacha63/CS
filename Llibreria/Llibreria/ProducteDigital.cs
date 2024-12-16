using Llibreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProducteDigital : Producte
{
    public string Format { get; set; }

    public ProducteDigital(string nom, decimal preu, string format)
        : base(nom, preu)
    {
        Format = format;
    }

    public override string MostrarDetalls()
    {
        return $"{Nom} (Digital) - Preu: {Preu:C}, Format: {Format}";
    }
}