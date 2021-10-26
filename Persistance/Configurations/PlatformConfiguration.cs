using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
    class PlatformConfiguration : IEntityTypeConfiguration<Platform>

    { 
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder.ToTable(nameof(Platform));


            builder.Property(Platform => Platform.Id).ValueGeneratedOnAdd();

            //builder.Property(account => account.AccountType).HasMaxLength(50);

            //builder.Property(account => account.DateCreated).IsRequired();
        }
    
}
}