using System;
using System.Collections.Generic;

namespace DenLilleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            List<Customer> customers = new List<Customer>();
            Menu m = new Menu();
            m.ListMenu();
            
            while (true)
            {
                int ind = int.Parse(Console.ReadLine());

                if (ind != null)
                {
                    if (ind >= 0 && ind < 9)
                    {
                        switch (ind)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Opret Kunde");
                                Console.WriteLine("ID");
                                int ID = int.Parse(Console.ReadLine());
                                Console.WriteLine("Fornavn");
                                string Fname = Console.ReadLine();
                                Console.WriteLine("EfterNavn");
                                string Ename = Console.ReadLine();
                                Console.WriteLine("Mobil Nummer");
                                int MobilN = int.Parse(Console.ReadLine());
                                Console.WriteLine("Email");
                                string Em = Console.ReadLine();
                                Console.WriteLine("y/n vil du gemme det??");
                                string YN = Console.ReadLine().ToLower();

                                if (YN == "y")
                                {
                                    customers.Add(new Customer(ID, Fname, Ename, MobilN, Em));
                                    Console.WriteLine("Kunde er blevet gemt");
                                    Console.WriteLine("Kunde ID: ");
                                    Console.WriteLine("Navn: ");
                                    Console.WriteLine("Mobil Nummer: ");
                                    Console.WriteLine("Email: ");
                                    Console.WriteLine("\n\n1. vis du vil oprette en kunde til");
                                    Console.WriteLine("8. vis du vil tilbage til Menuen");
                                }
                                else
                                {
                                    break;
                                }
                                
                                break;
                            case 2:
                                Console.WriteLine("Hej med digg");
                                break;
                            case 3:
                                Console.WriteLine("Hej med diggg");
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 7:
                                break;
                            case 8:
                                Console.Clear();
                                m.ListMenu();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
