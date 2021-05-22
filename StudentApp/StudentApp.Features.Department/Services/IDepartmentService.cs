using StudentApp.Features.Department.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Features.Department.Services
{
    public interface IDepartmentService
    {
        Task<DepartmentModel> AddDepatmentAsync(DepartmentModel model);
    }
}
