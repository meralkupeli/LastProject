﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAL.Domain.Entity
{
    public class Sprint :BaseEntity
    {
        public DateTime CreatedDate { get; set; } 
        public string Name { get; set; }
    }
}
