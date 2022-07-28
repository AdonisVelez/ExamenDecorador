using System;

namespace Examen
{
    public class NewBaseType
    {
        public static void Main(string[] arg)
        {

            var Helado1 = new HeladoChocolate();
            Console.WriteLine("$"+Helado1.CalculoTotalPrecio());
            //Console.WriteLine();

            var Adereso1 = new Topping1(Helado1);
            Console.WriteLine("$"+Adereso1.CalculoTotalPrecio());

            var Adereso2 = new Topping2(Adereso1);
            Console.WriteLine("$"+Adereso2.CalculoTotalPrecio());

            Console.WriteLine();

         
        }
    }
}
