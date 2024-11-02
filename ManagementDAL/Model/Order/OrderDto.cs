using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDAL.Domain.Entity;

namespace ManagementDAL.Model.Order
{
    public class OrderDto : BaseModel
    {
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public object Id { get; set; }
    }
}
