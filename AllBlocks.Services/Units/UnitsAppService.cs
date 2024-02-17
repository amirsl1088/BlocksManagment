using AllBlocks.Entities;
using AllBlocks.Services.Units.contracts;
using AllBlocks.Services.Units.contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace AllBlocks.Services.Units
{
    public class UnitsAppService : UnitService
    {
        private readonly UnitRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public UnitsAppService(UnitRepository repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(AddUnitDto dto)
        {
            var unit = new Unit
            {
                Name = dto.Name,
                RoomCount = dto.RoomCount,
                BlockId=dto.BlockId
            };
            _repository.Add(unit);
          await  _unitOfWork.Complete();
        }
    }
}
