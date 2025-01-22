using ManagementDAL.Domain.Entity;
using ManagementDAL.Domain;
using ManagementDAL.IRepository;
using ManagementDAL.UnitOfWork;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManagementDAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    //Disposable: İşlem tamamlandığında, bağlantıyı serbest bırakmanız gerekir
    //kaynağın doğru şekilde kapanması veya temizlenmesi anlamına gelir
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity; // İstediğimiz Generic Repositoryleri Tek bir yerden Üretmemizi sağlayacak.
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
