using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new Result(true, "Öğrenci eklendi.");
        }

        public Student GetByStudentId(int id)
        {
            return _studentDal.Get(s=>s.StudentId == id);
        }
    }
}
