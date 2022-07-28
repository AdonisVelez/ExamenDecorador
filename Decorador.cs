using System;

namespace Examen {
public class Decorador : HeladoBase
{
    protected HeladoBase orden;
    public Decorador (HeladoBase orden)
    {
        this.orden = orden;
        
    }

    public override double CalculoTotalPrecio()
    {
        //Console.WriteLine("Calculo del precio total desde la clase decorador");
        return orden.CalculoTotalPrecio();
    }

}
}