using IKYS.Domain.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Data.Mapping
{
    public class PersonelBaseMapping : IEntityTypeConfiguration<PersonelBase>
 
    {
        public void Configure(EntityTypeBuilder<PersonelBase> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnOrder(1);

            builder.Property(x => x.Name)
                .HasColumnName("NAME")
                .HasColumnOrder(2);

            builder.Property(x => x.Surname)
                .HasColumnName("SURNAME")
                .HasColumnOrder(3);

            builder.Property(x => x.City)
                .HasColumnName("CITY")
                .HasColumnOrder(4);

            builder.Property(x => x.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasColumnOrder(5);

            builder.Property(x => x.BirthDay)
                .HasColumnName("BIRD_DAY")
                .HasColumnOrder(6);

            //builder.Property(x => x.Gender)       //Geri dönülecek.
            //    .HasColumnName("GENDER")
            //    .HasColumnOrder(7);
            
            //a
        }
    }
}
