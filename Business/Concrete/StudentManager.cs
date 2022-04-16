using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public List<Student> GetByStudentSchoolId(int id)
        {
            return _studentDal.GetAll(s => s.StudentSchoolId == id);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public List<Student> GetByStudentCardNumber(int cardId)
        {
            return _studentDal.GetAll(s=>s.StudentCardNumber == cardId);
        }

        public List<StudentDetailDTO> GetStudentDetails()
        {
            return _studentDal.GetStudentDetails();
        }
    }
}
