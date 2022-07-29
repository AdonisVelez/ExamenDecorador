using System;

namespace Examen {
public class HeladoChicle : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Total del Helado: ");
        var valor = 1.25;
        return valor;
    }
}
}
