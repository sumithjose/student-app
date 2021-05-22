using StudentApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentApp.Features.Student.Entities
{
    public class Profile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Place { get; set; }
        public string Pin { get; set; }

        [ForeignKey("DepartmentId")]
        public Department.Entities.Department Department { get; set; }
    }
}
