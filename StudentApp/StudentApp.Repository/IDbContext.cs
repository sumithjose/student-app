using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Repository
{
    public interface IDbContext
    {
        int SaveChanges();
        void Dispose();
    }
}
