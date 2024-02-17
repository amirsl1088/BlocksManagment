using AllBlocks.Entities;
using AllBlocks.Services.Units.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Persistence.EF.Units
{
    public class EFUnitRepository : UnitRepository
    {
        private readonly EFDataContext _context;
        public EFUnitRepository(EFDataContext context)
        {
            _context = context;
        }
        public void Add(Unit unit)
        {
            _context.Units.Add(unit);
        }
    }
}
