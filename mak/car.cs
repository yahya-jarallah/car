using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{
    internal class car:vehicle
    {
        public new int spead(int gear)
        {
            return gear;
            //Console.WriteLine("  the num car" + gear);
        }
        public new    void volum()
        {
            Console.WriteLine("this size mediem .....");
        }
        public new void print()
        {

            Console.WriteLine
                ("the name  car" + "  " + name

                ); Console.WriteLine
                ("the color person" + "  " + color);
            Console.WriteLine("the is model made car" +
             + Model_years);

            Console.WriteLine
                ("the  price car:" + "  " + Price);


        }
    }
}

