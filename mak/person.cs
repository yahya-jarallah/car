using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{
    internal class person {
        string _Name;
        string _Address;
        int _Age;
        int _Id;
        //        public class person(string Name, string Address,int Age,
        //            int Id){
        //}

        public  person(
            //string name,string address,int age,int id
            ){
            this._Name = " ";
            this._Address = " ";
            this._Age = 0;
            this._Id = 0;
        }
        public string name
        {
            get
            { return this._Name; }
            set
            {if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine(_Name = "no name");
            else this._Name = value;
                
            }
        }
        public int age
        {
            get { return this._Age; }
            set
            {
                //int x;

                //x = int.Parse(Console.ReadLine());
                if (value < 15) Console.WriteLine("found not Age negtive .....");
                else if (value > 90)
                    Console.WriteLine("big age");
                //  Console.WriteLine( _Age =  big age');

                else this._Age = value;
            }
        }
        public int id {
            get
            { return _Id; }
            set { if(value<0||value>999999999)
           Console.WriteLine( "not id negtiv or most of nine" +
                        " number");
           else this._Id = value;
                    ///value = _Id; 
                    } }

        public string address
        {
            get
            { return _Address; }
            set { if (string.IsNullOrWhiteSpace(value))
                    //_Address = "not addrees";
                    Console.WriteLine(_Address = "not found address");
                else this._Address = value;
                    }
        }
        public void print()
        {
            
            Console.WriteLine
                ("the name person" + "  " +name
                
                );Console.WriteLine
                ("the address person" + "  " +address);
            Console.WriteLine("the is age employee :"  + age);
                
            Console.WriteLine
                ("the id person" + "  " + id);

            
        }

    }
}
