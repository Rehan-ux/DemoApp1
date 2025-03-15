using DemoApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.ModelConfigrations
{
    internal class EmplyeeConfigration : IEntityTypeConfiguration<Emplyee>
    {
        public void Configure(EntityTypeBuilder<Emplyee> builder)
        {
            //builder.HasKey(E => E.EmpId);
            //builder.Property<string>("Name");
            //builder
            //    .Property(E => E.EmpName)
            //    .HasColumnName("EmplyeeName")
            //    .HasMaxLength(50)
            //    .IsRequired(false);
            //builder.OwnsOne(E => E.Address, Address => Address.WithOwner());
        }
    }
}
