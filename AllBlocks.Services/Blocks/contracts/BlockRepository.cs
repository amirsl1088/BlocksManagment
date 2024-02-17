using AllBlocks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Services.Blocks.contracts
{
    public interface BlockRepository
    {
        void Add(Block block);

    }
}
