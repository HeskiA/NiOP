using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeskiAntonioTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime novaGodina = new DateTime(
            DateTime.Now.Year + 1, 1, 1);
            TimeSpan preostalo = novaGodina - DateTime.Now;
            Console.WriteLine("Do Nove godine preostalo je:");

            Console.WriteLine("Dana: " + Convert.ToInt32(preostalo.TotalDays));
            Console.WriteLine("Sati: " + Convert.ToInt32(preostalo.TotalHours));
            Console.WriteLine("Minuta: " + Convert.ToInt32(preostalo.TotalMinutes));
            Console.WriteLine("Sekundi: " + Convert.ToInt32(preostalo.TotalSeconds));
            Console.ReadKey();
        }
    }
}
