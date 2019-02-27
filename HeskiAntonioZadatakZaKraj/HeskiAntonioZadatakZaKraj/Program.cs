using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeskiAntonioZadatakZaKraj.Klase;

namespace HeskiAntonioZadatakZaKraj
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo motocikl = new Vozilo();
            motocikl.setVrsta("Motocikl");
            motocikl.setBrojKotaca(2);
            Console.WriteLine("Upisi max brzinu motocikla");
            motocikl.setMaxBrzina(Convert.ToInt32(Console.ReadLine()));

            Vozilo automobil = new Vozilo();
            automobil.setVrsta("Automobil");
            automobil.setBrojKotaca(4);
            automobil.setMaxBrzina(motocikl.getMaxBrzina() * 1.30);

            Console.WriteLine(motocikl.ToString());
            Console.WriteLine(automobil.ToString());

            Console.ReadLine();
        }
    }
}
