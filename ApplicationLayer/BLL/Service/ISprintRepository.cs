using ManagementDAL.Domain.Entity;

namespace ApplicationLayer.BLL.Service
{
    internal interface ISprintRepository
    {
        Sprint Add(Sprint sprint);
        void Delete(int id);
        List<Sprint> GetAll();
        Sprint GetById(int id);
        Sprint Update(Sprint sprint);
    }
}