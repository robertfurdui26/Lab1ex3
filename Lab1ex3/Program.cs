using System;

namespace Lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex3.Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
            tastaura*/

            int numar = 2345;
            int ultimaCifra = Math.Abs(numar) % 10 ;
            Console.WriteLine("Ultima cifra a numarului " + numar + " este "  +ultimaCifra);
        }
    }
}