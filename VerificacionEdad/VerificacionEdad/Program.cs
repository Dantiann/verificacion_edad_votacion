using System;

namespace VerificacionEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre: ");
            var name = Console.ReadLine();
            Console.WriteLine("Ingrese el año de nacimiento: ");
            var Birthday = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name + ". Birhday: " + Birthday);

            Console.WriteLine("***************");

            if (Birthday <= 2005)
            {
                Console.WriteLine(name + ", nacidO(a) en " + Birthday + " !ES APTO(A) PARA VOTAR¡");
            }
            else
            {
                Console.WriteLine(name + ", nacid(a) en " + Birthday + " !NO ES APTO(A) PARA VOTAR¡");
            }

            Console.ReadKey();
        }
    }
}