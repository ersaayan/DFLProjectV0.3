
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryStudentDal : IStudentDal
    {
        List<Student> _students;
        public InMemoryStudentDal()
        {
            _students = new List<Student>
            {
                new Student{StudentId = 1, StudentSchoolId = 847, StudentFirstName = "Eren Ali", StudentLastName = "Şavk", StudentCardNumber = 123456789},
                new Student{StudentId = 2 , StudentSchoolId = 848, StudentFirstName = "Eren", StudentLastName = "Şavk", StudentCardNumber = 123456788},

            };
        }
        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Delete(Student student)
        {
            Student studentToDelete = _students.SingleOrDefault(s=>s.StudentId == student.StudentId);

            _students.Remove(student);
        }

        public Student Get(Expression<Func<Student, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public List<Student> GetAll(Expression<Func<Student, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetByStudentSchoolId(int studentSchoolId)
        {
            return _students.Where(s=>s.StudentSchoolId == studentSchoolId).ToList();


        }

        public List<StudentDetailDTO> GetStudentDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            Student studentToUpdate = _students.SingleOrDefault(p => p.StudentId == student.StudentId);
            studentToUpdate.StudentId = student.StudentId;
            studentToUpdate.StudentSchoolId = student.StudentSchoolId;
            studentToUpdate.StudentFirstName = student.StudentFirstName;
            studentToUpdate.StudentLastName = student.StudentLastName;
            studentToUpdate.StudentCardNumber = student.StudentCardNumber;

        }
    }
}
