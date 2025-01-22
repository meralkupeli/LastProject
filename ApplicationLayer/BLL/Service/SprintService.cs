using ApplicationLayer.BLL.IService;
using ManagementDAL.Domain.Entity;
using ManagementDAL.Model.Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.BLL.Service
{
    internal class SprintService : ISprintService
    {
        private readonly ISprintRepository _sprintRepository;

        public SprintService(ISprintRepository sprintRepository)
        {
            _sprintRepository = sprintRepository;
        }

        public Sprint CreateSprint(Sprint sprint)
        {
            return _sprintRepository.Add(sprint);
        }

        public Sprint GetSprint(int id)
        {
            return _sprintRepository.GetById(id);
        }

        public List<Sprint> GetAllSprints()
        {
            return _sprintRepository.GetAll();
        }

        public Sprint UpdateSprint(Sprint sprint)
        {
            return _sprintRepository.Update(sprint);
        }

        public void DeleteSprint(int id)
        {
            _sprintRepository.Delete(id);
        }

        public List<SprintDto> GetSprints()
        {
            throw new NotImplementedException();
        }

        SprintDto ISprintService.GetSprint(int id)
        {
            throw new NotImplementedException();
        }
    }
}
