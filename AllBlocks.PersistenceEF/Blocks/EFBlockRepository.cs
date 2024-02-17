using AllBlocks.Entities;
using AllBlocks.Services.Blocks.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Persistence.EF.Blocks
{
    public class EFBlockRepository : BlockRepository
    {
        private readonly EFDataContext _context;
        public EFBlockRepository(EFDataContext context)
        {
            _context = context;
        }
        public void Add(Block block)
        {
            _context.Blocks.Add(block);
        }
    }
}
