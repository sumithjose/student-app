using Microsoft.EntityFrameworkCore;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Exam.Data
{
    public interface IExamDataContext : IDataContext
    {
        DbSet<Exam.Entities.Exam> Exam { get; set; }
        DbSet<Exam.Entities.ExamReport> ExamReport { get; set; }
    }
}
