using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{
    internal class customer : person

    { public customer()
        {

        }
        //string _card;
        //public string Card
        //{
        //    get { return _card; }
        //    set
        //    {//if(value=) 

        //        _card = value;
        //    }
        //}
        public new void print()
        {
            Console.WriteLine
                ("the name customer" + "  " + name

                ); Console.WriteLine
                ("the address customer" + "  " + address);
            Console.WriteLine ("the is age employee or" +
                " customer:" + age);

            Console.WriteLine
                ("the id person" + "  " + id);
            
        }
    }
}