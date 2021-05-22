using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Exam.Models
{
    public class ExamModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ExamName { get; set; }
        public string Topics { get; set; }
    }
}
