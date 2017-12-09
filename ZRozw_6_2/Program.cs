using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student();
            student1.WypiszInfo();
            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba("Jan", "Kowalski"));
            osoby.Add(new Student("Anna", "Nowak", 1, 2, 34567));
            osoby.Add(new Osoba("Anna", "Nowaczyk"));
            foreach (var element in osoby)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
