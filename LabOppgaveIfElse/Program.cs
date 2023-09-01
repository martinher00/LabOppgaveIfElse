using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOppgaveIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatur();

            Console.ReadLine();
        }

        static void Temperatur()
        {
            // Deklarering av variabler
            bool res;
            int temperatur;
            string input;

            do
            {
                Console.Write("Tast inn en temperatur: ");

                input = Console.ReadLine();
                res = int.TryParse(input, out temperatur);

                if (res)
                {
                    if(temperatur > 0)
                    {
                        Console.WriteLine("Plussgrader.");
                    }
                    else if (temperatur < 0)
                    {
                        Console.WriteLine("Minusgrader.");
                    }
                    else
                    {
                        Console.WriteLine("Det er null det.");
                    }
                }
                else
                {
                    Console.WriteLine("Ikke et gyldig tall!\nPress any key...");

                    Console.ReadKey();
                    Console.Clear();
                }
            } while (res == false); // Fortsetter loopen om res == false
        }
    }
}
