using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDAL.Domain.Entity;
using ManagementDAL.Model.Order;
using ManagementDAL.Model.Product;

namespace ManagementDAL.Model.OrderProduct
{
    public class OrderProductDto : BaseModel
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int OrderId { get; set; }
        public OrderDto Order { get; set; }
    }
}
