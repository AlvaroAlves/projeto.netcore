using AngularDotnet.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // referenciar o builder
            builder.HasKey(u => u.Id);
            
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(500);
            
            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);

            //Mapeamento 1 para muitos
            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
