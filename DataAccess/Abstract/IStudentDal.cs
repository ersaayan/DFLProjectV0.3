using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

    public interface IStudentDal:IEntityRepository<Student>
    {

        List<StudentDetailDTO> GetStudentDetails(Expression<Func<Student, bool>> filter = null);
        StudentDetailDTO GetDetail(Expression<Func<Student, bool>> filter);
}
