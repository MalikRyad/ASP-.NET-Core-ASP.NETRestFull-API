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
    class CommandConfiguration : IEntityTypeConfiguration<Command>
    {

        public void Configure(EntityTypeBuilder<Command> builder)
        {
            builder.ToTable(nameof(Command));

            builder.HasKey(Command => Command.Id);  

          //builder.Property(account => account.Id).ValueGeneratedOnAdd();

            //builder.Property(account => account.AccountType).HasMaxLength(50);

            //builder.Property(account => account.DateCreated).IsRequired();
        }

    }
}
