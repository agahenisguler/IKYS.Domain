using IKYS.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Data.Mapping
{
    public class FinanceMapping : IEntityTypeConfiguration<Finance>

    {
        public void Configure(EntityTypeBuilder<Finance> builder)
        {
            builder.Property(x => x.OffDay)
                .HasColumnName("OFF_DAY")
                .HasColumnOrder(15);

            builder.Property(x => x.MounthWage)
                .HasColumnName("MOUNTH_WAGE")
                .HasColumnOrder(16);


        }

    }
}
