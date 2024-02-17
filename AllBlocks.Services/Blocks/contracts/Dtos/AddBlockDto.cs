using AllBlocks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Services.Blocks.contracts.Dtos
{
    public class AddBlockDto
    {
        public string Name { get; set; }
        public int UnitCount { get; set; }
        public Entities.Type Type { get; set; }
    }
}
