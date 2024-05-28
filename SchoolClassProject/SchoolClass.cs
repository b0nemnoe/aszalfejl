using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public SchoolClass(int evfolyam, string azonosito, int fizetendoPenz, int diakokSzama)
        {
            Evfolyam = evfolyam;
            Azonosito = azonosito;
            FizetendoPenz = fizetendoPenz;
            DiakokSzama = diakokSzama;
        }
        public SchoolClass() 
        { 
            Evfolyam = 0;
            Azonosito = string.Empty;
            FizetendoPenz = 0;
        }

        public int Evfolyam { get; set; }
        public string Azonosito { get; set; }
        public int FizetendoPenz {  get; set; }
        public int DiakokSzama { get; set; }

        public override string ToString()
        {
            return $"{Evfolyam}.{Azonosito} ({FizetendoPenz} Ft)";
        }

        

        
    }
}
