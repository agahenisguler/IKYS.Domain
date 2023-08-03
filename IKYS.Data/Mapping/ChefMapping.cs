using IKYS.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Data.Mapping
{
    public class ChefMapping : IEntityTypeConfiguration<Chef>

    {
        public void Configure(EntityTypeBuilder<Chef> builder)
        {
            builder.Property(x => x.OffDay)
               .HasColumnName("OFF_DAY")
               .HasColumnOrder(11);

            builder.Property(x => x.MounthWage)
               .HasColumnName("MOUNTH_WAGE")
               .HasColumnOrder(12);

            builder.Property(x => x.Shift)
               .HasColumnName("SHIFT")
               .HasColumnOrder(13);

            builder.Property(x => x.HauseRent)
               .HasColumnName("HAUSE_RENT")
               .HasDefaultValueSql("0")
               .HasColumnOrder(14);


        }
    }
}
