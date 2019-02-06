using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeskiAntonioKlaseObjekti.Klase;

namespace HeskiAntonioKlaseObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avijon = new Vozilo();
            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");

            Console.WriteLine("Vrsta: " + avijon.getVrsta() + " Oznaka: " + avijon.getOznaka() + " Vozi:" + avijon.getVozi() + 
                " Pliva:" + avijon.getPliva() + " Leti:" + avijon.getLeti() + " Broj kotaca: " + avijon.getBrojKotaca());

            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI-1987-AR");
            Console.WriteLine(kamijon.ToString());
            Console.ReadKey();
        }
    }
}
