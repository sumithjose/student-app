using StudentApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.DepartMent.Entities
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public string Type { get; set; }
    }
}
