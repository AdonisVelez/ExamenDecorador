using System;

namespace Examen {
public class Topping1 : Decorador
{
    public Topping1(HeladoBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecio()
    {
        //Console.WriteLine("Se añade topping 1");
        //Console.Write("Nuevo Precio del ");
        var Adiccion = base.CalculoTotalPrecio() + 0.50;
        
        return Adiccion;
    }
}
}