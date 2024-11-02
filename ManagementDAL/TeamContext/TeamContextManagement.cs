using ManagementDAL.Domain.Entity;
using ManagementDAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAL.TeamContext
{
    internal class TeamContextManagement
    {
        public interface IUnitOfWork : IDisposable
        {
            IRepository<T> GetRepository<T>() where T : BaseEntity; // İstediğimiz Generic Repositoryleri Tek bir yerden Üretmemizi sağlayacak.
            void SaveChanges();
            Task SaveChangesAsync();
        }
    }
}
