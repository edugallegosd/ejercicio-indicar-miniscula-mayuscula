using System;

namespace prueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("Ingrese un caracter: ");
            caracter = char.Parse(Console.ReadLine());

            if (caracter >= 'a' && caracter <= 'z') {
                Console.WriteLine("La letra " + caracter + " es miniscula");
            }else if(caracter >= 'A' && caracter <= 'Z') {
                Console.WriteLine("La letra " + caracter + " es mayuscula");
            }else{
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }
    }
}
