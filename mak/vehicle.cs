using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{
    internal class vehicle
    {
        string _Name;
        string _Color;
        int _Model_years;
        double _Price;
                              
         public vehicle()
        {
            this._Name = " ";
            this.color = " ";
            this.Price = 0;
            this.Model_years = 0;


        }               
               

        //int spead;
        public string name
        {
            get
            { return this._Name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine(_Name = "no name");
                else this._Name = value;

            }
        }
        public string color
        {
            get { return this._Color; }
            set { this._Color = value; }
        }
        public int Model_years { get 
            { return this._Model_years; } 
            set { if (value < 2015)
                    Console.WriteLine("this is can not ");
              else  this._Model_years = value;
                
            }

        }
        public double Price { get {
                return this._Price; }
            set 
            {if (value < 200000)
                
                    Console.WriteLine("this is found price vehicle" +
                    "");
                else this._Price = value;
            } }
        public virtual void spead(int gear)
        {
            Console.WriteLine("  the num vehicle....." + gear);
        }
        public virtual void volum()
        {
            Console.WriteLine("this size  vehicle.....");
        }
        public virtual void print()
        {

            Console.WriteLine
                ("the name vehicle:" + "  " + name

                ); Console.WriteLine
                ("the address vehicle:" + "  " + color);
            Console.WriteLine("the is  model_year vehicle:" + Model_years);

            Console.WriteLine
                ("the price vehicle:" + "  " + Price);


        }
    }
}
