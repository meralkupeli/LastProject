using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ManagementDAL.Domain.Entity;
using ManagementDAL.Model.Order;
namespace ManagementDAL.IRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        public Task AddAsync(T entity);
        public Task AddRange(IEnumerable<T> entity);

        public void Delete(T entity);
        public Task Delete(Guid id);

        public Task Delete(Expression<Func<T, bool>> predicate);
        public void DeleteRange(List<T> entities);

        public Task<List<T>> GetAll();

        public IQueryable<T> GetAllQuery();

        public Task<List<T>> GetAll(Expression<Func<T, bool>> predicate);
        public Task<T> GetById(Guid id);

        public Task<T> GetById(Expression<Func<T, bool>> predicate);

        public void Update(T entity);

        public void UpdateRange(List<T> entity);

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<bool> Contains(T entity);
        object GetOrder(int id);
        object GetProduct(int productId);
        Order GetOrder(object id);
        List<OrderDto> GetOrders();
        void Add(Order order);
        void Add(OrderProduct orderProduct);
    }
}
