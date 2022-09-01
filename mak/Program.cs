using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak
{
    internal class Program
    {

        static void Main(string[] args)
        {
{
 int h;
 do
                { Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t*******************************" +
                           "********************************************");

Console.WriteLine("\t\t\t$\t\t\t press 1 record the customer :\t\t\t$\n\n\n");
Console.WriteLine("\t\t\t*******************************" +
       "********************************************");

Console.WriteLine("\t\t\t$\t\t\t press 2  record  the " + "employee:\t\t\t$\n\n\n");
Console.WriteLine("\t\t\t*******************************" + "*********************************");
                    Console.WriteLine("\t\t\t$\t\t\t press 3  the record  " + " murd:\t\t\t$\n\n\n");
                    Console.WriteLine("\t\t\t***************************************************************************");
                    Console.WriteLine("\t\t\t$\t\t\t press 4  the record   bus:" +
                        "\t\t\t$\n\n\n"); Console.WriteLine("\t\t\t*******************************" +
       "********************************************");
                    Console.WriteLine("\t\t\t$\t\t\t press 5  the record   " +
    "car:\t\t\t$\n\n\n");
                    Console.WriteLine("\t\t\t*******************************" +
                         "********************************************");

                    Console.WriteLine("\t\t\t$\t\t\t press -1  to exit the program:" +
                       "\t\t\t$\n");

                    Console.WriteLine("\n\n\n\t\t\t*******************************" +
                                  "********************************************\n");

                    h = int.Parse(Console.ReadLine());
                    switch (h)
                    {
                        case 1:
                            {
                                customers();
                            }
                            break;
                        case 2:
                            {
                                emp();
                            }
                            break;
                        case 3:
                            {
                                Murds();//cars();
                            }
                            break;
                        case 4:
                            {
                                buses();
                            }
                            break;
                        case 5:
                            {
                                cars();
                            }
                            break;
                        case -1:
                            {
                                // هذا للضغط عليها يخرجك من البرنامج بالكامل

                                return;

                               

                            }
                    }
                } while (h != 0);
            }
            



            void customers()
            {
                int id, age;
                string name, address;
                customer cus = new customer();
                Console.Write("Enter name the customer: ");
                name = string.Format(Console.ReadLine());
                cus.name = name;
                Console.Write("Enter address the customer: ");
                address = string.Format(Console.ReadLine());
                cus.address = address;
                Console.Write("Enter Age the customer: ");
                age = int.Parse(Console.ReadLine());
                cus.age = age;
                Console.Write("Enter Id the customer: ");
                id = int.Parse(Console.ReadLine());
                cus.id = id;
                customer[] customer = { cus };
                Console.WriteLine("****************************");
                for (int i = 0; i < customer.Length; i++)
                    customer[i].print();
                int x;
                
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        {
                            x = 'x';
                        }
                        break;
                }

                Console.Clear();
                
            }
            void emp()
            {
                int id, age;
                string name, address;
                employee e = new employee();
                Console.WriteLine("Enter name  the employee:");
                name = string.Format(Console.ReadLine());
                e.name = name;
                Console.WriteLine("Enter Address  the employee:");
                address = string.Format(Console.ReadLine());
                e.address = address;
                Console.WriteLine("Enter Age the employee: ");
                age = int.Parse(Console.ReadLine());
                e.age = age;
                Console.WriteLine("Enter Id the employee:");
                id = int.Parse(Console.ReadLine());
                e.id = id;

                int salary;
                Console.WriteLine("Enter salary the employee:");
                salary = int.Parse(Console.ReadLine());
                e.salary = salary;
                 employee[] employee = { e };
            
                
                
                Console.WriteLine("**************************");
                for (int i = 0; i < employee.Length; i++)
                    employee[i].print();
                Console.Write("Enter the bons salary :");
                Console.WriteLine(e.bounssalary(salary));
                int x;
            
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            x = 'x';


                        }
                        break;
                }

                Console.Clear();

            }
            void Murds()
            {
                int id, age;
                string name, country, address;
                Murd m = new Murd();
                Console.WriteLine("Enter name  the murd:");
                name = string.Format(Console.ReadLine());
                m.name = name;
                Console.Write("Enter address the murd:");
                address = string.Format(Console.ReadLine());
                m.address = address;
                Console.Write("Enter age the murd:  ");
                age = int.Parse(Console.ReadLine());
                m.age = age;
                Console.Write("Enter id the murd:");
                id = int.Parse(Console.ReadLine());
                m.id = id;
                Console.Write("Enter country the murd: ");
                country = string.Format(Console.ReadLine());
                m.Country = country;
                 Murd[] Murd = { m };
                Console.WriteLine("**************************");
                for (int i = 0; i < Murd.Length; i++)
                    Murd[i].print();
                int x;
                
                 x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            x = 'x';


                        }
                        break;
                }
                Console.Clear();
            }
            void cars()
            {
                int  model_years, price;
                string name, color;

                car c = new car();
                Console.WriteLine("Enter name car:");
                name = string.Format(Console.ReadLine());
                c.name = name;
                Console.WriteLine("Enter color car :");
                color = string.Format(Console.ReadLine());
                c.color = color;
                Console.WriteLine("Enter price car : ");
                price = int.Parse(Console.ReadLine());
                c.Price = price;
                Console.WriteLine("Enter  model_ years  car:");
                model_years = int.Parse(Console.ReadLine());
                c.Model_years = model_years;
                int gear;
                Console.WriteLine("Enter gear the car:");
                gear = int.Parse(Console.ReadLine());
                car[] car = { c };
                Console.WriteLine("**************************");
                for (int i = 0; i < car.Length; i++)
                   
                    car[i].print();
                c.spead(gear);
                Console.WriteLine("the gear car:" + gear);
                c.volum();
                int x;
               
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            x = 'x';
                        }
                        break;
                }
                Console.Clear();
            }
            void buses()
            {
                int model_years, price;
                string name, color;

                bus b = new bus();
                Console.WriteLine("Enter name bus :");
                name = string.Format(Console.ReadLine());
                b.name = name;
                Console.WriteLine("Enter color bus:");
                color = string.Format(Console.ReadLine());
                b.color = color;
                Console.WriteLine("Enter price the bus: ");
                price = int.Parse(Console.ReadLine());
                b.Price = price;
                Console.WriteLine("Enter  model_ years  bus:");
                model_years = int.Parse(Console.ReadLine());
                b.Model_years = model_years;
                int gear;
                Console.WriteLine("Enter the gear bus:");
                gear = int.Parse(Console.ReadLine());

                Console.WriteLine("**************************");
                bus[] bus = { b };
                for (int i = 0; i < bus.Length; i++)
                    bus[i].print();
                b.spead(gear);
                Console.WriteLine("the gear car:" + gear);
                b.volum();

                int x;
              
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            x = 'x';
                        }
                        break;
                }
                Console.Clear();
            }

            Console.Clear();
        }

    }
    }    

