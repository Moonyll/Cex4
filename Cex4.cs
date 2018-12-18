using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Identifiant ?");
            string login = Console.ReadLine();
            Console.WriteLine("Mot de passe ?");
            string password = Console.ReadLine();
            if (login == "stef" && password == "007") // Attention au double ==
                Console.WriteLine("« Bienvenue à la Manu le Havre. »");
            else
                Console.WriteLine("« Mauvais identifiant ou mauvais mot de passe. »");
        }
    }
}
