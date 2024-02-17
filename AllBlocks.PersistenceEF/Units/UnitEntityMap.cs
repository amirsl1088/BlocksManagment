using AllBlocks.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Persistence.EF.Units
{
    public class UnitEntityMap : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.ToTable("Units");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).HasColumnType("nvarchar").IsRequired();
            builder.Property(_ => _.RoomCount).HasColumnType("int").IsRequired();
        }
    }
}
