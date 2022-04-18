using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<List<Student>> GetByStudentSchoolId(int id);
        IDataResult<List<Student>> GetByStudentCardNumber(int cardId);
        IDataResult<List<StudentDetailDTO>> GetStudentDetails();
        IDataResult<Student> GetByStudentId(int id);
        IResult Add(Student student);

    }
}
