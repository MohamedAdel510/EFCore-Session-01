﻿using EFCoreFluntAPIS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey( D => D.DeptId );
            builder.Property( D => D.DeptId ).UseIdentityColumn(10 ,10);

            builder.Property(D => D.Name)
                .HasColumnName("DeptName")
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
