using AngularDotnet.Dominio.Entidades;
using AngularDotnet.Dominio.ObjetoDeValor;
using AngularDotnet.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Repositorio.Contexto
{
    public class AngularDotnetContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
     
        public AngularDotnetContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Referenciar as classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Descricao = "Forma de Pagamento Boleto",
                    Nome = "Boleto"
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Descricao = "Forma de Pagamento Cartão de crédito",
                    Nome = "Cartão de crédito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Descricao = "Forma de pagamento Depósito",
                    Nome = "Depósito"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
