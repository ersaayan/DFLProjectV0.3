using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager(new EfStudentDal());
            //StudentTest();
            Student student = new Student();
            student.StudentId = 27;
            student.StudentFirstName = "Mustafa";
            student.StudentLastName = "Düzdaş";
            student.StudentCardNumber = 923456764;
            student.StudentSchoolId = 798;
            student.SchoolId = 0;
            var islemR = studentManager.Update(student);
            Console.WriteLine(islemR.Message);

        }

        private static void StudentTest()
        {
            StudentManager studentManager = new StudentManager(new EfStudentDal());

            var result = studentManager.GetStudentDetails();
            
            if (result.IsSuccess==true)
            {
                foreach (var item in result.Data)
                {


                    Console.WriteLine("Öğrenci IDsi: " + item.StudentId + " " + "Öğrenci No: " + item.StudentSchoolId + " Öğrenci Adı Ve Soyadı: " + item.StudentFirstName + " " + item.StudentLastName + " Okul Adı: " + item.SchoolName);
                    Console.WriteLine();
                    
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            


        }
    }
}
