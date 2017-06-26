using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class computer {
        public int Id;
        public string Name;
        public string Color;
        public int Ram;

        ~computer()
        {
            System.Diagnostics.Trace.WriteLine("لقد تم الهدم");
        }
        public computer(int id, string name, string color, int ram) {
            Id = id;
            Ram = ram;
            Color = color;
            Name = name;
            
        }
        public void PrintInfo() {
            
            Console.WriteLine("\n The Informations Of The Computer #{0}:",Id);
            Console.WriteLine("Computer Id: {0}", Id);
            Console.WriteLine("Computer Name: {0}", Name);
            Console.WriteLine("Computer Color: {0}", Color);
            Console.WriteLine("Computer Ram: {0}", Ram);
            Console.WriteLine("=============================");


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            computer computer1 = new computer(01, "Toshipa", "Red",8);
            computer1.PrintInfo();


            computer computer2 = new computer(02, "Dell", "White",16);
            computer2.PrintInfo();


            computer computer3 = new computer(03, "Apple", "Black", 16);
            computer3.PrintInfo();


            Console.ReadKey();


        }
    }
}
