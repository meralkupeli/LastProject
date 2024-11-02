using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAL.Model.Order
{
    public class UpdateOrderDto:BaseModel
    {
        public string Name { get; set; }
        public object Id { get; set; }
    }
}
