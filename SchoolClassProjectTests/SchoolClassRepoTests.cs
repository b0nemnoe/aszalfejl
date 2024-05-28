using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class SchoolClassRepoTests
    {
        [TestMethod()]
        public void MostPaidSchoolClassSameAmount()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
               new List<SchoolClass>
               {
                    new SchoolClass(9, "a", 5000, 25),
                    new SchoolClass(9, "b", 5000, 25),
               }
           );
            // act
            string actual = schoolClassRepo.MostPaidSchoolClass();
            string expected = "9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.";
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaidSchoolClassEmpty()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>());
            // act
            string actual = schoolClassRepo.MostPaidSchoolClass();
            string expected = string.Empty;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaidSchoolClassSameAmountLessStudent()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
               new List<SchoolClass>
               {
                    new SchoolClass(9, "a", 5000, 25),
                    new SchoolClass(9, "b", 5000, 26),
               }
            );
            // act
            string actual = schoolClassRepo.MostPaidSchoolClass();
            string expected = "9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.";
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaidSchoolClassMoreAmountSameStudent()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
               new List<SchoolClass>
               {
                    new SchoolClass(9, "a", 5000, 25),
                    new SchoolClass(9, "b", 4000, 25),
               }
            );
            // act
            string actualSchoolClass = schoolClassRepo.MostPaidSchoolClass();
            string expectedSchoolClass = "9.a";
            // assert
            Assert.AreEqual(expectedSchoolClass, actualSchoolClass);
        }
    }
}