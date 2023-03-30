using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja2_izpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto a = new Avto("Janez Novak", "GO*111", 3, DateTime.Parse("1.1.2022"));
            a.servisi[0] = new Servis(DateTime.Parse("1.1.2022"), "Mehanik", 12350, 200);
            a.servisi[1] = new Servis(DateTime.Parse("1.2.2022"), "Mehanik", 13350, 200);
            a.servisi[2] = new Servis(DateTime.Parse("1.3.2022"), "Mehanik", 14350, 200);
            Console.WriteLine(a.Izpis());
            Console.WriteLine("******************************************");
            a.SpremeniLastnika("Marija Novak", DateTime.Parse("1.4.2022"));
            a.servisi[0] = new Servis(DateTime.Parse("1.1.2022"), "Mehanik", 12350, 200);
            Console.WriteLine(a.Izpis());
            Console.ReadLine();

        }
    }
}
