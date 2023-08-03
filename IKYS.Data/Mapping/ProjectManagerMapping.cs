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
    public abstract class ProjectManagerMapping : IEntityTypeConfiguration<ProjectManager>

    {
        public void Configure(EntityTypeBuilder<ProjectManager> builder)
        {
            builder.Property(x => x.OffDay)
               .HasColumnName("OFF_DAY")
               .HasColumnOrder(8);

            builder.Property(x => x.MounthWage)
               .HasColumnName("MOUNTH_WAGE")
               .HasColumnOrder(9);

            builder.Property(x => x.HauseRent)
               .HasColumnName("HAUSE_RENT")
               .HasDefaultValueSql("0")
               .HasColumnOrder(10);
        }

    }
}
