using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDAL.Domain.Entity;
using ManagementDAL.Model.Order;

namespace ApplicationLayer.BLL.IService
{
    public interface IOrderService
    {
        List<OrderDto> GetOrders();

        OrderDto GetOrder(int id);

        void Add(CreateOrderDto order);
        void Update(UpdateOrderDto order);
        void Delete(DeleteOrderDto order);
    }
}
