using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Department.Data
{
    public class DepartmentRepository : Repository<Department.Entities.Department>, IDepartmentRepository
    {
        public DepartmentRepository(IDataContext context) : base(context)
        {

        }
    }
}
