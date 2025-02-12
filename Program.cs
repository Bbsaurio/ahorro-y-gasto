using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorro_y_gasto
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inserta el ahorro");
            double H=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta el gasto");
            double G=double.Parse(Console.ReadLine());
            if (H>G)
            {
                System.Console.WriteLine("S O L V E N T E");
                H=H- G;
                G = 0;
            }
            else
            {
                System.Console.WriteLine("Q U I E B R A");
            }
            Console.WriteLine($"Ahorro final:"+H);
            Console.WriteLine($"Gasto final:"+G);
            Console.ReadKey();
        }
    }
}
