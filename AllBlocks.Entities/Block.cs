using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Entities
{
    public class Block
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitCount { get; set; }
        public Type Type { get; set; }
        public HashSet<Unit> Units { get; set; }
    }
}
