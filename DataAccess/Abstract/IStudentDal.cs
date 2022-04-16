using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

    public interface IStudentDal:IEntityRepository<Student>
    {
        List<StudentDetailDTO> GetStudentDetails();
    }
