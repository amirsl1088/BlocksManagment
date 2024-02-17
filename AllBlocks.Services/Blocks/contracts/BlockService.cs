using AllBlocks.Services.Blocks.contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Services.Blocks.contracts
{
    public interface BlockService
    {
        Task Add(AddBlockDto dto); 
    }
}
