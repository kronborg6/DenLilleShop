using System;
using System.Collections.Generic;

namespace ConsoleAppParts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of parts.
            List<Part> parts = new List<Part>();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 }); ;
            // Name intentionally left null.
            parts.Add(new Part() { PartId = 1334 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });

            // Write out the parts in the list. This will call the overridden 
            // ToString method in the Part class.
            Console.WriteLine("\nBefore sort:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // Check the list for part #1734. This calls the IEquatable.Equals method
            // of the Part class, which checks the PartId for equality.
            Console.WriteLine("\nContains: Part with Id=1734: {0}",
                parts.Contains(new Part { PartId = 1734, PartName = "" }));

            // Find items where name contains "seat".
            Console.WriteLine("\nFind: Part where name contains \"Seat\": {0}",
                parts.Find(x => x.PartName.Contains("seat")));

            // Check if an item with Id 1444 exists.
            Console.WriteLine("\nExists: Part with Id=1444: {0}",
                parts.Exists(x => x.PartId == 1444));

            Console.WriteLine("\nTest HasCode: {0}",
            parts[1].GetHashCode());

            // Call Sort on the list. This will use the 
            // default comparer, which is the Compare method 
            // implemented on Part.
            parts.Sort();

            Console.WriteLine("\nAfter sort by part number:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // This shows calling the Sort(Comparison(T) overload using 
            // an anonymous method for the Comparison delegate. 
            // This method treats null as the lesser of two values.
            parts.Sort(delegate (Part x, Part y)
            {
                if (x.PartName == null && y.PartName == null) return 0;
                else if (x.PartName == null) return -1;
                else if (y.PartName == null) return 1;
                else return x.PartName.CompareTo(y.PartName);
            });

            Console.WriteLine("\nAfter sort by name:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.ReadLine();
        }
    }
}
