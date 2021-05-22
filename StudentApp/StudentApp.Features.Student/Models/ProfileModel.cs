using StudentApp.Features.Department.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Student.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Place { get; set; }
        public string Pin { get; set; }
        public DepartmentModel Department { get; set; }
    }
}
