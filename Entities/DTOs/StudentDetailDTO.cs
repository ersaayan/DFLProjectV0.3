using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class StudentDetailDTO:IDto
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public int StudentSchoolId { get; set; }
        public int StudentCardNumber { get; set; }
        public string SchoolName { get; set; }

    }
}
