using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDAL.Domain.Entity;

namespace ManagementDAL.Model.Product
{
    public class CreateProductDto : BaseModel
    {
        public object ProductId;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
