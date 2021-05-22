using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentApp.Features.Department.Models
{
    public class DepartmentModel
    {
        [Required]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public string Type { get; set; }
    }
}
