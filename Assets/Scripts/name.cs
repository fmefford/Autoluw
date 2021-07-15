using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace randomnamegenerator

{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] first = new String[] {"Adam", "Allan", "Brian", "Bob", "Collin", "Cole", "Connor", "Kwami",
                                          "Hasan", "Greg", "Joseph", "Roberto", "James", "Jaime", "Miguel", "Michael",
                                          "Asad", "Mohammed", "Jeff", "Kyle", "John", "Alejandro", "DeShawn"};
            String[] last = new String[] {"Roberts", "Smith", "Rodriguez", "St. James", "O'Connor", "Williams", "Dial", "Merrick"};

            string n = "";
            Random rnd = new Random();
            int x = -1;
            int y = -1;

            x = rnd.Next(0, first.Length);
            y = rnd.Next(0, last.Length);

         Console.WriteLine(first[x] + " " + last[y]);
            

        }
    }
}