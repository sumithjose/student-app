using StudentApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Exam.Entities
{
    public class Exam : BaseEntity
    {
        public string ExamName { get; set; }
        public string Topics { get; set; }
    }
}
