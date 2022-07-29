using System;

namespace Examen {
public class HeladoChocolate : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Total del Helado: ");
        var valor = 1.50;
        return valor;
    }
}
}
