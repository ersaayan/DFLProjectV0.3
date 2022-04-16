using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        List<Student> GetByStudentSchoolId(int id);
        List<Student> GetByStudentCardNumber(int cardId);
        List<StudentDetailDTO> GetStudentDetails();

    }
}
