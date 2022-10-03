using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANAK AYAM TURUN 10");
            Console.WriteLine("");

            Console.Write("Masukkan Ayam : ");
            int anakayam1 = int.Parse(Console.ReadLine());
            int anakayam2 = anakayam1 - 1;
            Console.WriteLine("");


            if(anakayam1 >= 1 && anakayam1 <=10)
            {
                for (int i = anakayam1; i > 0; i--)
                {
                    if (i > 1)
                    {
                        int j = i - 1;
                        Console.WriteLine("Anak ayam turunlah " + i + ", mati satu tinggalah " + j);
                    }
                    else 
                    {
                        Console.WriteLine("Anak ayam turunlah 1, mati satu tinggal induknya");
                    }
                    
                }
            } else
            {
                Console.WriteLine("Nilai N tidak sesuai");
            }
            

    
                

   
        }
    }
}
