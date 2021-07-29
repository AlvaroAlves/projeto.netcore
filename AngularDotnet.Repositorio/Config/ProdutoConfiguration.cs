using AngularDotnet.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.Descricao)
                .HasMaxLength(400)
                .IsRequired();

            builder
                .Property(u => u.Preco)
                .IsRequired();
        }
    }
}
