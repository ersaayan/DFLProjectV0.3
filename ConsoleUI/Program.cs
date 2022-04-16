using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentTest();

        }

        private static void StudentTest()
        {
            StudentManager studentManager = new StudentManager(new EfStudentDal());

            //foreach (var item in studentManager.GetAll())
            // {
            //     Console.WriteLine("Öğrenci No: "+item.StudentSchoolId + " Öğrenci Adı Ve Soyadı: " + item.StudentFirstName +" " +item.StudentLastName + " Öğrenci Kart Numarası: " + item.StudentCardNumber );
            // }

            foreach (var item in studentManager.GetStudentDetails())
            {
                Console.WriteLine("Öğrenci No: " + item.StudentSchoolId + " Öğrenci Adı Ve Soyadı: " + item.StudentFirstName + " " + item.StudentLastName + " Öğrenci Kart Numarası: " + item.StudentCardNumber + " Okul Adı: " + " " + item.SchoolName);
            }
        }
    }
}
