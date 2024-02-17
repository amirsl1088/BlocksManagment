using AllBlocks.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Persistence.EF.Blocks
{
    public class BlockEntityMap : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.ToTable("Blocks");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).HasColumnType("nvarchar").IsRequired();
            builder.Property(_ => _.UnitCount).HasColumnType("int").IsRequired();
            builder.Property(_ => _.Type).HasColumnType("byte").IsRequired();
                
        }
    }
}
