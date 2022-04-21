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

        public IDataResult<Student> GetByStudentSchoolId(int id)
        {
            var result = _studentDal.Get(s => s.StudentSchoolId == id);
            if (result == null)
            {
                return new ErrorDataResult<Student>(Messages.StudentNotFound);
            }
            return new SuccessDataResult<Student>(_studentDal.Get(s => s.StudentSchoolId == id), Messages.StudentListed);
        }

        public IDataResult<List<Student>> GetAll()
        {
            if (DateTime.Now.Hour==09)
            {
                return new ErrorDataResult<List<Student>>(Messages.MeintenanceTime);
            }
            return new  SuccessDataResult<List<Student>>(_studentDal.GetAll(),Messages.StudentListed);
        }

        public IDataResult<Student> GetByStudentCardNumber(int cardId)
        {
            var result = _studentDal.Get(s => s.StudentCardNumber == cardId);
            if (result == null)
            {
                return new ErrorDataResult<Student>(Messages.StudentNotFound);
            }
            return new SuccessDataResult<Student>(_studentDal.Get(s=>s.StudentCardNumber == cardId), Messages.StudentListed);
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
            var result = _studentDal.Get(s => s.StudentId == id);
            if (result == null)
            {
                return new ErrorDataResult<Student>(Messages.StudentNotFound);
            }
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
            var result = _studentDal.GetDetail(s => s.StudentSchoolId == studentSchoolId);
            if (result == null)
            {
                return new ErrorDataResult<StudentDetailDTO>(Messages.StudentNotFound);
            }
            return new SuccessDataResult<StudentDetailDTO>(_studentDal.GetDetail(s=>s.StudentSchoolId==studentSchoolId), Messages.StudentListed);
        }
    }
}
