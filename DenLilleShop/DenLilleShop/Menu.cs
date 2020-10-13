using System;
using System.Collections.Generic;
using System.Text;

namespace DenLilleShop
{
    public class Menu
    {
        public Menu()
        {

        }

        public void ListMenu()
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("\n             Hvad vil du");
            Console.WriteLine("\n             1. Oprette Kunder");
            Console.WriteLine("             2. Oprette Varer");
            Console.WriteLine("             3. Oprette Ordre");
            Console.WriteLine("             4. Vise kundernes ordre");
            Console.WriteLine("             5. Slet Menu");
            Console.WriteLine("\n*******************************************");
        }
        public void SletMenu()
        {
            Console.Clear();
            Console.WriteLine("\n*******************************************");
            Console.WriteLine("1. Slet Kunde");
            Console.WriteLine("2. Slet Varer");
            Console.WriteLine("3. Slet Order");
            Console.WriteLine("4. Tilbage");
            Console.WriteLine("*******************************************");
        }
        public void AllMenu()
        {
            Console.Clear();
            Console.WriteLine("\n*******************************************");
            Console.WriteLine("\n              Vis alle");
            Console.WriteLine("\n              1. Alle Kunder");
            Console.WriteLine("              2. Alle Vare");
            Console.WriteLine("              2. Alle Order");
            Console.WriteLine("\n*******************************************");
        }

    }
}
