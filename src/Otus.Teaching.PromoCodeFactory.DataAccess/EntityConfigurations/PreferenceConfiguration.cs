using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.EntityConfigurations
{
    public class PreferenceConfiguration: IEntityTypeConfiguration<Preference>
    {
        public void Configure(EntityTypeBuilder<Preference> builder)
        {
            builder.ToTable("Preferencis").HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(Preference.NameMaxLength);
        }
    }
}
