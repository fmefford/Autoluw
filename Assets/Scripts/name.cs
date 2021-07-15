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
            String[] first = new String[] {"Brown", "Black", "White", "Orange", "Wild", "Tiger", "Snow Leopard", "Koo",
                                          "Kooapps", "Gray", "Zombie", "Gumdrop", "Candy", "Choco", "Darth", "Dark",
                                          "Goldfish on a", "Evil", "German", "Beach", "City", "Haunted", "Spooky"};
            String[] last = new String[] {"Dog", "Cat", "Dalmation", "Bird", "Koobird", "Goldfish", "Turtle", "Clyde",
                                         "Selina", "Troy", "Oscar", "Lily", "Skateboard", "Swim E Fresh", "Pip", "Leo",
                                         "Raph", "Donny", "Mikey", "Man", "Sloth", "Ferret", "Grandpa", "Voviboye"};

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