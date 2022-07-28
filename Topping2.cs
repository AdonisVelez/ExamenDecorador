using System;

namespace Examen {
public class Topping2 : Decorador
{
    public Topping2(HeladoBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecio()
    {
        
        var Adiccion = base.CalculoTotalPrecio() + 0.45;
        
        return Adiccion;
    }
}
}
