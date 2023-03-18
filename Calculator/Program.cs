using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Äplikasi Calculator";


            int a, b, c;
            Console.WriteLine("Pilih menu kalkulator: ");
            Console.WriteLine("\n\n 1. Penambahan");
            Console.WriteLine("\n\n 2. Pengurangan");
            Console.WriteLine("\n\n 3. Perkalian");
            Console.WriteLine("\n\n 4. Pembagian");
            Console.Write("Input nomor menu [1..4]= ");
             a = int.Parse(Console.ReadLine());

            int pilih = a;
            switch (pilih)
            {
                case 1:
                    Console.Write("Masukan nilai 1: ");
                     b = int.Parse(Console.ReadLine());
                    Console.Write("Masukan nilai 2: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Penambahan " + b + " + " + c + " = " + Penambahan(b, c));
                    break;
                case 2:
                    Console.Write("Masukan nilai 1: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Masukan nilai 2: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", b, c, Pengurangan(b, c));
                    break;
                case 3:
                    Console.Write("Masukan nilai 1: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Masukan nilai 2: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan {0} * {1} = {2} ", b, c, Perkalian(b, c));
                    break;
                case 4:
                    Console.Write("Masukan nilai 1: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Masukan nilai 2: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan {0} / {1} = {2} ", b, c, Pembagian(b, c));
                    break;
            }
    


        }
        static float Penambahan(float b, float c)
        {
            return b + c;
        }
        static float Pengurangan(float b, float c)
        {
            return b - c;
        }
        static float Perkalian(float b, float c)
        {
            return b * c;
        }
        static float Pembagian(float b, float c)
        {
            return b / c;
        }
    }
}
