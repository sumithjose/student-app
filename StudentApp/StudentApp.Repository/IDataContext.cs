using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Repository
{
    public interface IDataContext : IDbContext
    {
        DbSet<T> Set<T>() where T : class;
        EntityEntry Entry(object entity);
    }
}
