using Microsoft.EntityFrameworkCore;
using StudentApp.Features.Department.Data;
using StudentApp.Features.Department.Entities;
using StudentApp.Features.Exam.Data;
using StudentApp.Features.Exam.Entities;
using StudentApp.Features.Student.Data;
using StudentApp.Features.Student.Entities;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Data
{
    public class DataContext : DbContext, IDataContext, IStudenDataContext, IExamDataContext, IDepartmentDataContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<ExamReport> ExamReport { get; set; }
        public virtual DbSet<Department> Department { get; set; }
    }
}
