using IKYS.Domain.Abstract;
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
    public class BuyMapping : IEntityTypeConfiguration<Buy> 

    {
        public void Configure(EntityTypeBuilder<Buy> builder)
        {
            builder.Property(x => x.OffDay)
                .HasColumnName("OFF_DAY")
                .HasColumnOrder(17);

            builder.Property(x => x.MounthWage)
                .HasColumnName("MOUNTH_WAGE")
                .HasColumnOrder(18);

            builder.Property(x => x.Bonus)
                .HasColumnName("BONUS")
                .HasColumnOrder(19);

        }

    }
}
