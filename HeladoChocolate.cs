using System;

namespace Examen {
public class HeladoChocolate : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Total del Helado: ");
        var H1 = 1.50;
        return H1;
    }
}
}