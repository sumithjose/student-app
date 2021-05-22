using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Exam.Data
{
    public class ExamRepository : Repository<Exam.Entities.Exam>, IExamRepository
    {
        public ExamRepository(IDataContext context) : base(context)
        {

        }
    }
}
