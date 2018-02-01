using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunniHarjutus_Kohvik_
{
    class Program
    {
        static void Main(string[] args)
        {
            var Money = 20.0f;
            var Kohv = new MustKohv();
            Money = Kohv.Pay(Money);

            Console.ReadLine();
        }
    }
}
