using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DenLilleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
            List<LiterProduct> literProducts = new List<LiterProduct>();
            List<GramProduct> gramProducts = new List<GramProduct>();
            List<Order> orders = new List<Order>();
            Product Test = new LiterProduct();
            //Test.Liter = 12;
            Menu m = new Menu();
            DenLilleShopDB c = new DenLilleShopDB();

            customers.Add(new Customer() { CustomerID = 1, Fornavn = "Mikkel", Efternavn = "Kronborg", MobilNummer = 60677407, Email = "mkronborg7@gmail.com" });
            customers.Add(new Customer() { CustomerID = 2, Fornavn = "Tina", Efternavn = "Nilsen", MobilNummer = 24070605, Email = "t.kronborg6@gmail.com" });
            customers.Add(new Customer() { CustomerID = 3, Fornavn = "Allan", Efternavn = "Andersen", MobilNummer = 85858032, Email = "AllanAndersen@gmail.com" });
            customers.Add(new Customer() { CustomerID = 4, Fornavn = "Mads", Efternavn = "Madsen", MobilNummer = 60677407, Email = "Mads032@gmail.com" });

            products.Add(new Product() { ProductId = 1, Name = "Mar's Bar", Price = 10 });
            products.Add(new Product() { ProductId = 2, Name = "500g Slik", Price = 25 });
            products.Add(new Product() { ProductId = 3, Name = "Gave Kort 100 Kr", Price = 100 });
            products.Add(new Product() { ProductId = 4, Name = "kasse Coca Cola", Price = 70 });

            m.ListMenu();
            try
            {
                c.SqlInteractionn();
            }
            catch (SqlException exp)
            {
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(exp.Message);
            }
            /*try
            {
                c.AddCustomer();
            }
            catch (SqlException exp)
            {
                Console.WriteLine("Something went wrong whit add .");
                Console.WriteLine(exp.Message);
            }*/
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
                                Console.WriteLine("Efternavn");
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
                                    Console.Clear();
                                    Console.WriteLine("Kunde er blevet gemt");
                                    Console.WriteLine("Kunde ID: " + ID);
                                    Console.WriteLine("Navn: " + Fname + " " + Ename);
                                    Console.WriteLine("Mobil Nummer: " + MobilN);
                                    Console.WriteLine("Email: " + Em);
                                    Console.WriteLine("\n\n1. vis du vil oprette en kunde til");
                                    Console.WriteLine("8. vis du vil tilbage til Menuen");
                                }
                                else
                                {
                                    Console.WriteLine("Du valgt ikke ja eller nej du vaglt: " + YN);
                                    Console.WriteLine("Prøv igen vis du ikke valger y eller n du vil ikke blive gemt");
                                    YN = Console.ReadLine().ToLower();
                                    if (YN == "y")
                                    {
                                        customers.Add(new Customer(ID, Fname, Ename, MobilN, Em));
                                        Console.Clear();
                                        Console.WriteLine("OKay så du ville gemme det!?!?");
                                        Console.WriteLine("\nKunde er blevet gemt");
                                        Console.WriteLine("Kunde ID: " + ID);
                                        Console.WriteLine("Navn: " + Fname + " " + Ename);
                                        Console.WriteLine("Mobil Nummer: " + MobilN);
                                        Console.WriteLine("Email: " + Em);
                                        Console.WriteLine("\n\n1. vis du vil oprette en kunde til");
                                        Console.WriteLine("8. vis du vil tilbage til Menuen");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Opret Vare");
                                Console.WriteLine("ID: ");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Vare Navn: ");
                                string ItemName = Console.ReadLine();
                                Console.WriteLine("Vare Prise: ");
                                float ItemPrice = float.Parse(Console.ReadLine());
                                Console.WriteLine("y/n vil du gemme det??");
                                YN = Console.ReadLine().ToLower(); 
                                if (YN == "y")
                                {
                                    products.Add(new Product(id, ItemPrice, ItemName));
                                    Console.Clear();
                                    Console.WriteLine("Varen er blevet gemt");
                                    Console.WriteLine("Varen ID: " + id);
                                    Console.WriteLine("Vare Navn: " + ItemName);
                                    Console.WriteLine("Vare Prise: " + ItemPrice);
                                    Console.WriteLine("\n\n1. vis du vil oprette en kunde til");
                                    Console.WriteLine("8. vis du vil tilbage til Menuen");
                                }
                                else
                                {
                                    Console.WriteLine("Du valgt ikke ja eller nej du vaglt: " + YN);
                                    Console.WriteLine("Prøv igen vis du ikke valger y eller n du vil ikke blive gemt");
                                    YN = Console.ReadLine().ToLower();
                                    if (YN == "y")
                                    {
                                        products.Add(new Product(id, ItemPrice, ItemName));
                                        Console.Clear();
                                        Console.WriteLine("Varen er blevet gemt");
                                        Console.WriteLine("Varen ID: " + id);
                                        Console.WriteLine("Vare Navn: " + ItemName);
                                        Console.WriteLine("Vare Prise: " + ItemPrice);
                                        Console.WriteLine("\n\n1. vis du vil oprette en kunde til");
                                        Console.WriteLine("8. vis du vil tilbage til Menuen");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                bool run = true;
                                Console.WriteLine("Create Order");
                                Console.WriteLine("\nOrder ID:");
                                id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Kunde ID:");
                                int KundeID = int.Parse(Console.ReadLine());
                                while (run)
                                {
                                    int itemID = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Test");
                                }
                                break;
                            case 4:
                                Console.Clear();
                                m.ListMenu();
                                foreach (Customer Cus in customers)
                                {
                                    Console.WriteLine(Cus.ToString());
                                    Console.WriteLine(Cus.CustomerID);
                                }
                                break;                            
                            case 10: // Test Case
                                Console.Clear();
                                m.ListMenu();
                                foreach (Customer Cus in customers)
                                {
                                    Console.WriteLine(Cus.ToString());
                                    Console.WriteLine(Cus.CustomerID);
                                }
                                break;
                            case 5:
                                break;
                            case 7:
                                Console.Clear();
                                m.AllMenu();
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
