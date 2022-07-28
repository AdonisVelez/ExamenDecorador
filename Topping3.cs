using System;

namespace Examen {
public class Topping3 : Decorador
{
    public Topping3(HeladoBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecio()
    {
        //Console.WriteLine("Se añade topping 3");
        //Console.Write("Nuevo Precio del ");
        var Adiccion = base.CalculoTotalPrecio() + 0.35;
        return Adiccion;
    }
}
}