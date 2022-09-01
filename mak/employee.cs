using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{
    internal class employee:person
    {
        int _salary;
        
        public employee()
        {
            this._salary = 0;
        }
        public int  salary
        {
            get
            {
                return this._salary;
            }
            set
            {if (value < 50)
                    Console.WriteLine("the salary" +
                        " less can not work in" +
                        " this iscompany......");
                else this._salary = value;
                
            }
        }
        public  int  bounssalary(int _salary)
        {
            return (this._salary / 30) * 1000;

        }
        public new void print()
        {
            Console.WriteLine
                ("the name employee" + "  " + name

                ); Console.WriteLine
                ("the address employee" + "  " + address);
            Console.WriteLine("the is age employee or:" + age);
            Console.WriteLine
                ("the id employee" + "  " + id);
            Console.WriteLine("the salary" +
            " employee in monthe:" + salary);
           // Console.clear();
        }
        
        
    }
}
