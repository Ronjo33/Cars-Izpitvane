using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cars_9d
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Car> Cars = new List<Car>();
            int numberOfsustezanie = 0;
            Console.WriteLine("shte vuvejdash li kola:");
            string command = "da";
            
            while (command != "stop")
            {
                Console.Write("Brand:");
                string brand = Console.ReadLine();

                Console.Write("Model:");
                string model = Console.ReadLine();

                Console.Write("Regisnum:");
                string registnum = Console.ReadLine();

                Console.Write("god");
                int god = int.Parse(Console.ReadLine());

                Car car = new Car(brand, model, registnum, god);
                Cars.Add(car);

                Console.Write("shte vuvejdash li kola, ako ne stop za krai:");
                command = Console.ReadLine();

                numberOfsustezanie++;
            }
            Console.WriteLine();
            foreach ( Car Car in Cars)
            {
                Car.Info();
                Car.dvijenie();
                Car.ECOstatus();
            }
            Console.WriteLine();
            Console.WriteLine($"sustezatelite v sustezanieto sa {numberOfsustezanie}");
        }
    }
}
