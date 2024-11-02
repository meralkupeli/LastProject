using ApplicationLayer.BLL.IService;
using ManagementDAL.Domain.Entity;
using ManagementDAL.Model.Order;
using ManagementDAL.IRepository;
using ManagementDAL.Repository.OrderRepository;
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
        private readonly IOrderRepository<Order> orderRepository;
        private readonly IProductRepository<Product> productRepository;
        private readonly IOrderProductRepository<OrderProduct> orderProductRepository;

        //Dependecy İnjection
        public OrderService(IOrderRepository<Order> orderRepository,
            IProductRepository<Product> productRepository,
            IOrderProductRepository<OrderProduct> orderProductRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.orderProductRepository = orderProductRepository;
        }
        #endregion

        public void Add(CreateOrderDto order)
        {
            var product = productRepository.GetProduct(order.ProductId);
            if (product != null)
            {
                var _order = new Order { Name = order.Name };
                orderRepository.Add(_order);
                orderProductRepository.Add(new OrderProduct { Id = _order.Id });

                //productRepositoryKaydet
            }

        }

        public void Delete(DeleteOrderDto order)
        {
            var _order = orderRepository.GetOrder(order.Id);

            if (_order != null)
            {
                orderRepository.Delete(_order);
            }
        }

        public OrderDto GetOrder(int id)
        {
            var _order = orderRepository.GetOrder(id);

            if (_order != null)
            {
                return new OrderDto
                {
                    CreateDate = _order.CreateDate,
                    Name = _order.Name,
                };
            }

            return null;
        }

        public List<OrderDto> GetOrders()
        {
            var orders = orderRepository.GetOrders() as List<OrderDto>;

            return orders.Select(x => new OrderDto
            {

                CreateDate = x.CreateDate,
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }

        public void Update(UpdateOrderDto order)
        {
            var _order = orderRepository.GetOrder(order.Id);

            _order.Name = order.Name;
            _order.CreateDate = DateTime.Now;

            orderRepository.Update(_order);
        }
    }
}
