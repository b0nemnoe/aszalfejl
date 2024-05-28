using System;

namespace SchoolClassProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchoolClass Osztaly1 = new SchoolClass(9, "a", 1000, 30);
            Console.WriteLine(Osztaly1);

            SchoolClass Osztaly2 = new SchoolClass(9, "b", 6000, 31);
            Console.WriteLine(Osztaly2);



            if (Osztaly1.FizetendoPenz > Osztaly2.FizetendoPenz)
            {

                Console.WriteLine($"{Osztaly1.Evfolyam}.{Osztaly1.Azonosito} osztály diákjai  havonta {Osztaly1.FizetendoPenz - Osztaly2.FizetendoPenz} forinttal többet fizetnek osztálypénzbe, mint {Osztaly2.Evfolyam}.{Osztaly2.Azonosito} osztály tanulói.");
            }
            else if (Osztaly1.FizetendoPenz < Osztaly2.FizetendoPenz)
            {
                Console.WriteLine($"{Osztaly2.Evfolyam}.{Osztaly2.Azonosito} osztály diákjai  havonta {Osztaly2.FizetendoPenz - Osztaly1.FizetendoPenz} forinttal többet fizetnek osztálypénzbe, mint {Osztaly1.Evfolyam}.{Osztaly1.Azonosito} osztály tanulói.");
            }
            else
            {
                Console.WriteLine($"{Osztaly1.Evfolyam}.{Osztaly1.Azonosito} és {Osztaly2.Evfolyam}.{Osztaly2.Azonosito} osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.");
            }

            int OsszFizetett1 = Osztaly1.FizetendoPenz * Osztaly1.DiakokSzama * 10;
            Console.WriteLine($"{Osztaly1.Evfolyam}.{Osztaly1.Azonosito} osztály {OsszFizetett1} Ft-ot fizetett be osztálypénzbe.");
            int OsszFizetett2 = Osztaly2.FizetendoPenz * Osztaly2.DiakokSzama * 10;
            Console.WriteLine($"{Osztaly2.Evfolyam}.{Osztaly2.Azonosito} osztály {OsszFizetett2} Ft-ot fizetett be osztálypénzbe.");
        }
    }
}