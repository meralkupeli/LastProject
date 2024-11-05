using ApplicationLayer.BLL.IService;
using ManagementDAL.Domain.Entity;
using ManagementDAL.Model.Order;
using ManagementDAL.IRepository;
using ManagementDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.BLL.Service
{
    public class OrderService :IOrderService
    {
        #region Dependecy Injection
        private readonly IRepository<Order> Repository;

        //Dependecy İnjection
        public OrderService(IRepository<Order> Repository)
        {
            this.Repository = Repository;
           
        }
        #endregion

        public void Add(CreateOrderDto order)
        {
            var product = Repository.GetProduct(order.ProductId);
            if (product != null)
            {
                var _order = new Order { Name = order.Name };
                Repository.Add(_order);
                Repository.Add(new OrderProduct { Id = _order.Id });

                //productRepositoryKaydet
            }

        }

        public void Delete(DeleteOrderDto order)
        {
            var _order = Repository.GetOrder(order.Id);

            if (_order != null)
            {
                Repository.Delete(_order);
            }
        }

        public OrderDto GetOrder(int id)
        {
            var _order = Repository.GetOrder(id);

            if (_order != null)
            {
                return new OrderDto
                {
                    CreateDate = _order.CreatedDate,
                    Name = _order.Name,
                };
            }

            return null;
        }

        public List<OrderDto> GetOrders()
        {
            var orders = Repository.GetOrders() as List<OrderDto>;

            return orders.Select(x => new OrderDto
            {

                CreateDate = x.CreateDate,
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }

        public void Update(UpdateOrderDto order)
        {
            var _order = Repository.GetOrder(order.Id);

            _order.Name = order.Name;
            _order.CreatedDate = DateTime.Now;

           Repository.Update(_order);
        }
    }
}
