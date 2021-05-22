using StudentApp.Features.Student.Entities;
using StudentApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentApp.Features.Exam.Entities
{
    public class ExamReport : BaseEntity
    {
        [ForeignKey("StudentId")]
        public Profile Profile { get; set; }
        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }
        public bool IsPassed { get; set; }
    }
}
