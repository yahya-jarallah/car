using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{
    internal class Murd:person
    {string country;
        public Murd()
        {
            Country = " ";
           
        }

        public string Country { get { return country; } 
            set {if (string.IsNullOrWhiteSpace(value))
                    country = "is not country......";
                    country = value; } }
        public new void print()
        {

            Console.WriteLine("the name murd almaeaddat:" + "  " + name

                ); 
            Console.WriteLine("the address person" + "  " + address);
            Console.WriteLine("the is age employee or" +
                " customer:" + age);

            Console.WriteLine
                ("the id person" + "  " + id);
            Console.WriteLine("the country  murida hre" +
                " almaeaddat"+Country);


        }
    }
}
