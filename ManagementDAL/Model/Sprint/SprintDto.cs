using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAL.Model.Sprint
{
    public class SprintDto : BaseModel
    {
        public DateTime CreateDate { get; set; }
        public SprintDto() { }
        public SprintDto(int id) { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
