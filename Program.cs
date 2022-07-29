using System;

namespace Examen
{
    public class NewBaseType
    {
        public static void Main(string[] arg)
        {

            var chocoate = new HeladoChocolate();
            Console.WriteLine("$"+chocolate.CalculoTotalPrecio());
            var adereso1 = new Topping1(chocolate);
            Console.WriteLine("$"+adereso1.CalculoTotalPrecio());
            var adereso2 = new Topping2(adereso1);
            Console.WriteLine("$"+adereso2.CalculoTotalPrecio());
            Console.WriteLine();

            var fresa = new HeladoFresa();
            Console.WriteLine("$"+frsa.CalculoTotalPrecio());
            var adereso3 = new Topping1(chocolate);
            Console.WriteLine("$"+adereso3.CalculoTotalPrecio());
            var adereso4 = new Topping2(adereso3);
            Console.WriteLine("$"+adereso2.CalculoTotalPrecio());
            Console.writeLine();

        }
    }
}
