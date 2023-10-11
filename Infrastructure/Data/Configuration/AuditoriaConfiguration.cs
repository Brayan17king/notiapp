using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
{
    public void Configure(EntityTypeBuilder<Auditoria> builder)
    {
        builder.ToTable("auditoria");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("bigint");

        builder.Property(x => x.NombreUsuario).IsRequired().HasMaxLength(40);
        builder.Property(x => x.DesAccion).HasColumnType("bigint");
    }
}