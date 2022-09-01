using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{ 
  
   
    internal class bus:vehicle
    {public override void volum()
        {
            Console.WriteLine("this size big.....");
        }
        public override void spead(int gear)
        {
            Console.WriteLine("  the num bus" + gear);

            //Console.WriteLine(" this  is bus ");
        }
        public override  void print()
        {

            Console.WriteLine
                ("the name bus:" + "  " + name

                ); Console.WriteLine
                ("the color the a bus :" + "  " + color);
            Console.WriteLine("the is model made the bus :" +
                 + Model_years);

            Console.WriteLine
                ("the  price the bus:"  + Price);


        }
    }
}

