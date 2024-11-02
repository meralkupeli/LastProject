using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Order :BaseEntity
    {
        public DateTime CreateDate { get; set; } 
        public string Name { get; set; }
    }
}
