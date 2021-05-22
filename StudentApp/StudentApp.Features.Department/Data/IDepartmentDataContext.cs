using Microsoft.EntityFrameworkCore;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Department.Data
{
    public interface IDepartmentDataContext : IDataContext
    {
        DbSet<Department.Entities.Department> Department { get; set; }
    }
}
