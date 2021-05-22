using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Exam.Data
{
    public interface IExamRepository : IRepository<Exam.Entities.Exam>
    {
    }
}
