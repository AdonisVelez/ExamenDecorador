using System;

namespace Examen {
public class Topping2 : Decorador
{
    public Topping2(HeladoBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecio()
    {
        //Console.WriteLine("Se añade topping 2");
        //Console.Write("Nuevo Precio del ");
        var Adiccion = base.CalculoTotalPrecio() + 0.45;
        
        return Adiccion;
    }
}
}



/*
        Console.WriteLine("Se añade topping 2");
        var Adiccion = base.CalculoTotalPrecio();
        return Adiccion + 0.50;
*/