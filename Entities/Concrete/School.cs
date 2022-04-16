using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class School:IEntity
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
    }
}
