using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Entities
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoomCount { get; set; }
        public int BlockId { get; set; }
        public Block Block { get; set; }
    }
}
