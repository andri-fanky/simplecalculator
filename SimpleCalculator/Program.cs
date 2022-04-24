using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class Program dapat menampilkan daftar menu dari aplikasi</remarks>
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        /// <remarks>method Main menampilkan menu, menerima input, dan memanggil method operasi pada class Kalkulator</remarks>
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Kalkulator Sederhana");
                Console.WriteLine("====================");
                Console.WriteLine("");
                Console.WriteLine("1. Pejumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("0. Keluar");
                Console.Write("Pilihan (1/2/3/4/0) : ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int n))
                {
                    int pilihan = Convert.ToInt32(input);
                    if (pilihan == 0)
                    {
                        exit = true;
                        return;
                    }
                    else if (pilihan == 1 || pilihan == 2 || pilihan == 3 || pilihan == 4)
                    {
                        Console.Write("Bilangan Pertama = ");
                        double bil1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bilangan Kedua = ");
                        double bil2 = Convert.ToInt32(Console.ReadLine());
                        string keterangan = "";
                        switch (pilihan)
                        {
                            case 1:
                                keterangan = "Hasil penjumlahan bilangan " + bil1 + " dan " + bil2 + " adalah " + calculator.Penjumlahan(bil1, bil2);
                                break;
                            case 2:
                                keterangan = "Hasil pengurangan bilangan " + bil1 + " dan " + bil2 + " adalah " + calculator.Pengurangan(bil1, bil2);
                                break;
                            case 3:
                                keterangan = "Hasil perkalian bilangan " + bil1 + " dan " + bil2 + " adalah " + calculator.Perkalian(bil1, bil2);
                                break;
                            case 4:
                                keterangan = "Hasil pembagian bilangan " + bil1 + " dan " + bil2 + " adalah " + calculator.Pembagian(bil1, bil2);
                                break;
                        }
                        Console.WriteLine(keterangan);
                        Console.WriteLine("");
                        Console.WriteLine("Tekan Enter untuk menampilkan menu...");
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Tidak ada pilihan yang dipilih...");
                        Console.WriteLine("");
                    }
                } else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Tidak ada pilihan yang dipilih...");
                    Console.WriteLine("");
                }
            }
        }
    }
}
