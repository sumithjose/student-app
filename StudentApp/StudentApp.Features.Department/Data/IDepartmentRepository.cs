using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Department.Data
{
    public interface IDepartmentRepository : IRepository<Department.Entities.Department>
    {
    }
}
