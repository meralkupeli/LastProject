using ManagementDAL.Domain.Entity;
using ManagementDAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManagementDAL.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork where T : class
    {
        private bool disposed = false;

        private TeamContext.TeamContextManagement _context;
        public UnitOfWork(TeamContext.TeamContextManagement context)
        {
            _context = context;
        }
        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository.Repository<T>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
