using System;

namespace Examen {
public class Topping1 : Decorador
{
    public Topping1(HeladoBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecio()
    {
        var Adiccion = base.CalculoTotalPrecio() + 0.50;
        
        return Adiccion;
    }
}
}
