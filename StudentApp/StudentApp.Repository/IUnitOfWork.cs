using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Repository
{
    public interface IUnitOfWork
    {
        int Commit();
        void Dispose();
    }
}
