using AllBlocks.Entities;
using AllBlocks.Services.Blocks.contracts;
using AllBlocks.Services.Blocks.contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace AllBlocks.Services.Blocks
{
    public class BlocksAppService : BlockService
    {
        private readonly BlockRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public BlocksAppService(BlockRepository repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task Add(AddBlockDto dto)
        {
            var block = new Block
            {
                Name = dto.Name,
                UnitCount = dto.UnitCount,
                Type = dto.Type
            };
            _repository.Add(block);
            _unitOfWork.Complete();
        }
    }
}
