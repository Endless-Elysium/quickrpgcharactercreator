using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlanketRPG
{
    internal class PlayerCreator
    {
        public static Player Create()
        {
            int vit, str, dex, mag, agi;
            vit = str = dex = mag = agi = 1;
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            int Points = 30;

            while (Points > 0)
            {
                Console.WriteLine("Which stat would you like to raise?");
                Console.WriteLine($"POINTS LEFT: {Points}");
                Console.WriteLine($"1: VIT: {vit}");
                Console.WriteLine($"2: STR: {str}");
                Console.WriteLine($"3: DEX: {dex}");
                Console.WriteLine($"4: MAG: {mag}");
                Console.WriteLine($"5: AGI: {agi}");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        vit += 1;
                        break;
                    case "2":
                        str += 1;
                        break;
                    case "3":
                        dex += 1;
                        break;
                    case "4":
                        mag += 1;
                        break;
                    case "5":
                        agi += 1;
                        break;
                    default:
                        continue;
                }
                Points--;
            }

            Player player = new Player(name, vit, str, dex, mag, agi);
            return player;
        }
    }
}
