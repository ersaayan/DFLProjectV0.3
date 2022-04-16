using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public int StudentSchoolId { get; set; }
        public int StudentCardNumber { get; set; }
        public int SchoolId { get; set; }
    }
}
