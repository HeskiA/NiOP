using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vozilo avijon = new Vozilo();

            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");

            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine("Vrsta: " + avijon.getVrsta() + " Oznaka: " +
                avijon.getOznaka() + "\nLeti: " + avijon.getLeti() + "\nPlovi: "+ avijon.getPliva()
                + "\nVozi: " + avijon.getVozi() + "\nBroj kotača: "+avijon.getBrojKotaca() + "\n");
            
            Console.WriteLine(kamijon.ToString());

            Console.WriteLine(avijon.ispis());

            */
            bool ponovniUnos = false;
            do
            {
                Console.WriteLine("Upišite podatke o vozilu");
                Console.WriteLine("Upišite broj kotača: ");
                int brojKotaca = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Leti? (y/n)");
                bool leti;
                if (Console.ReadLine().ToLower() == "y") { leti = true; } else leti = false;
                Console.WriteLine("Pliva? (y/n)");
                bool pliva;
                if(Console.ReadLine().ToLower()=="y") { pliva = true; } else pliva = false;
                bool vozi;
                Console.WriteLine("Vozi? (y/n)");
                if (Console.ReadLine().ToLower() == "y") { vozi = true; } else vozi = false;
                Console.WriteLine("Vrsta: ");
                string vrsta=Console.ReadLine();
                Console.WriteLine("Oznaka: ");
                string oznaka = Console.ReadLine();
                Vozilo objVozilo = new Vozilo(brojKotaca, leti, pliva, vozi, vrsta, oznaka);
                Console.WriteLine(objVozilo.ToString());
                Console.WriteLine("Ponovni unos? (y/n)");
                if (Console.ReadLine().ToLower() == "y") { ponovniUnos = true; } else ponovniUnos = false;
            } while (ponovniUnos == true);

            Console.WriteLine("Kraj unosa.");
            Console.ReadLine();
        }
    }

    
}
