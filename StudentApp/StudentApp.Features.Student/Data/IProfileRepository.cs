using StudentApp.Features.Student.Entities;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Features.Student.Data
{
    public interface IProfileRepository : IRepository<Profile>
    {
    }
}
