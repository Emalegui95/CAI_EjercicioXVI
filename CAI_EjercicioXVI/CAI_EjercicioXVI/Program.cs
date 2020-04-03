using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioXVI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            string num = Console.ReadLine();


            Console.WriteLine("El número " + num + " tiene " + num.Length + " dígitos");
            Console.ReadKey(true);
        }
    }
}

