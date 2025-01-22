using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDAL.Domain.Entity;
using ManagementDAL.Model.Order;
using ManagementDAL.Model.Sprint;
using ManagementDAL.UnitOfWork;


namespace ApplicationLayer.BLL.IService
{
    public interface ISprintService
    {
        List<SprintDto> GetSprints();

        SprintDto GetSprint(int id);
    }
}
