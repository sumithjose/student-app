using StudentApp.Features.Student.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Exam.Models
{
    public class ExamReportModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public ProfileModel Profile { get; set; }
        public ExamModel Exam { get; set; }
        public bool IsPassed { get; set; }
    }
}
