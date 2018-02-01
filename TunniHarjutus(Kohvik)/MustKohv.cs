using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunniHarjutus_Kohvik_
{
    class MustKohv : Joogid
    {
        public MustKohv()
        {
            Name = "MustKohv";

            Size1 = "S";
            Price1 = 1.5f;

            Size2 = "M";
            Price2 = 2.5f;

            Size3 = "L";
            Price3 = 3.5f;

            PriceName = "€";

            
        }

        public float Pay(float Money)
        {
            Console.WriteLine("Tere, kas te soovite kohvi osta?");
            if(valik1 == valik2)
            {
                Console.WriteLine("Meil on erisuurusega Kohvid!");
            }
            //Console.WriteLine("Meil on erisuurusega Kohvid!");
            if (Name == "MustKohv")
            {
                Console.WriteLine("Mis suurusega kohvi te tahate");
            }
            else
            {
                Console.WriteLine("???");
            }

            Console.WriteLine("Sina ostsid musta kohvi");
            var YourMoney = Money - 1.5;
            Console.WriteLine("Sul on alles" + YourMoney);
            return Money - 1.5f;

        }
    }
}
