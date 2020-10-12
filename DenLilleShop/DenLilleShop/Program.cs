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
                                Customer.Add(new Customer());
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
