using AllBlocks.Services.Units.contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Services.Units.contracts
{
    public interface UnitService
    {
        Task Add(AddUnitDto dto);
    }
}
