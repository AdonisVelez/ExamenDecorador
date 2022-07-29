using System;

namespace Examen {
public class HeladoFresa : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Total del Helado: ");
        var valor = 1.50;
        return valor;
    }
}
}

