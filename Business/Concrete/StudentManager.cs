using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<List<Student>> GetByStudentSchoolId(int id)
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(s => s.StudentSchoolId == id), Messages.StudentListed);
        }

        public IDataResult<List<Student>> GetAll()
        {
            if (DateTime.Now.Hour==09)
            {
                return new ErrorDataResult<List<Student>>(Messages.StudentNotListed);
            }
            return new  SuccessDataResult<List<Student>>(_studentDal.GetAll(),Messages.StudentListed);
        }

        public IDataResult<List<Student>> GetByStudentCardNumber(int cardId)
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(s=>s.StudentCardNumber == cardId), Messages.StudentListed);
        }

        public IDataResult<List<StudentDetailDTO>> GetStudentDetails()
        {
            return new SuccessDataResult<List<StudentDetailDTO>>(_studentDal.GetStudentDetails(), Messages.StudentListed);
        }

        public IResult Add(Student student)
        {
            if (student.StudentFirstName.Length <2)
            {
                return new ErrorResult(Messages.StudentNameInvalid);
            }
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IDataResult<Student> GetByStudentId(int id)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(s=>s.StudentId == id), Messages.StudentListed);
        }

        public IResult Delete(Student student)
        {

            _studentDal.Delete(student);
            return new SuccessResult(Messages.StudentDeleted);
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.StudentUpdated);

        }

        public IDataResult<StudentDetailDTO> GetDetailByStudentSchoolId(int studentSchoolId)
        {
            return new SuccessDataResult<StudentDetailDTO>(_studentDal.GetDetail(s=>s.StudentSchoolId==studentSchoolId), Messages.StudentListed);
        }
    }
}
