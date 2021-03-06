using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfStudentDal : EfEntityRepositoryBase<Student, DflStudentDataContext>, IStudentDal
    {
        public StudentDetailDTO GetDetail(Expression<Func<Student, bool>> filter)
        {
            using (DflStudentDataContext context = new DflStudentDataContext())
            {
                var result = from s in context.Students.Where(filter)
                             join s2 in context.Schools on
                             s.SchoolId equals s2.SchoolId
                             select new StudentDetailDTO
                             {
                                 StudentId = s.StudentId,
                                 StudentFirstName = s.StudentFirstName,
                                 StudentLastName = s.StudentLastName,
                                 StudentSchoolId = s.StudentSchoolId,
                                 SchoolName = s2.SchoolName,
                                 StudentCardNumber = s.StudentCardNumber
                             };
                return result.SingleOrDefault();
            }
        }

        public List<StudentDetailDTO> GetStudentDetails(Expression<Func<Student, bool>> filter = null)
        {
            using (DflStudentDataContext context = new DflStudentDataContext())
            {
                var result = from s in context.Students
                             join s2 in context.Schools on
                             s.SchoolId equals s2.SchoolId
                             select new StudentDetailDTO
                             {
                                 StudentId = s.StudentId,
                                 StudentFirstName = s.StudentFirstName,
                                 StudentLastName = s.StudentLastName,
                                 StudentSchoolId = s.StudentSchoolId,
                                 SchoolName = s2.SchoolName,
                                 StudentCardNumber = s.StudentCardNumber
                             };
                return result.ToList();
            }
        }
    }
}
