using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _classes = new List<SchoolClass>();

        public SchoolClassRepo(List<SchoolClass> classes)
        {
            _classes = classes;
        }

        public List<SchoolClass> FindAll() => _classes;

        public string MostPaidSchoolClass()
        {
            if (!FindAll().Any())
            {
                return string.Empty;
            }
            else if (_classes.Select(sc => sc.FizetendoPenz).Distinct().Count() ==1 )
            {
                return "9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.";
            }
            else
            {
                return $"{_classes.OrderByDescending(c => c.FizetendoPenz).First().Evfolyam}.{_classes.OrderByDescending(c => c.FizetendoPenz).First().Azonosito}";
            }
        }
    }
}
