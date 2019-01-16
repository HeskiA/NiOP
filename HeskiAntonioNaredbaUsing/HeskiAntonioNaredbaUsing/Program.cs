using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HeskiAntonioNaredbaUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine("\n-- Zapisujemo u datoteku...");
            using (StreamWriter sw = new StreamWriter(
                    @"C:\Users\Ucenik\Desktop\datoteka.txt"))
            {
                sw.WriteLine("Ime: { 0}" + ime);
                sw.WriteLine("Prezime: { 0}" + prezime);
            }

            Console.WriteLine("\n-- Pročitano iz datoteke:");
            using (StreamReader sr = new StreamReader(
                   @"C:\Users\Ucenik\Desktop\datoteka.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadKey();
            

        }
    }
}

