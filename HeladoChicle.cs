using System;

namespace Examen {
public class HeladoChicle : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Total del Helado: ");
        var H2 = 1.25;
        return H2;
    }
}
}


/*using System;

namespace Examen {
public class HeladoChicle : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Helado Chicle: ");
        return Helados.Sum(x => x.Costo);
    }
}
}
*/