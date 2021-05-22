using StudentApp.Features.Exam.Entities;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Exam.Data
{
    public class ExamReportRepository : Repository<ExamReport>, IExamReportRepository
    {
        public ExamReportRepository(IDataContext context) : base(context)
        {

        }
    }
}
