using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Services.Units.contracts.Dtos
{
    public class AddUnitDto
    {
        public string Name { get; set; }
        public string RoomCount { get; set; }
        public int BlockId { get; set; }
    }
}
