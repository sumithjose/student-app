using Microsoft.EntityFrameworkCore;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _context;

        public UnitOfWork(IDataContext context)
        {
            _context = (DbContext)context;
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
