using AgroConecta.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroConecta.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Marketplace
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaProduto> CategoriasProduto { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItemPedido> ItensPedido { get; set; }

        public DbSet<Transacao> Transacoes { get; set; }

        // Fórum
        public DbSet<CategoriaForum> CategoriasForum { get; set; }

        public DbSet<TopicoModel> Topicos { get; set; }

        public DbSet<ComentarioModel> Comentarios { get; set; }

        // Agro
        public DbSet<Propriedade> Propriedades { get; set; }

        public DbSet<Relatorio> Relatorios { get; set; }

        public DbSet<Cultura> Culturas { get; set; }

        public DbSet<AtividadeAgricola> AtividadesAgricolas { get; set; }

        public DbSet<AnaliseCultura> AnalisesCulturas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AtividadeAgricola>()
            .HasOne(a => a.Propriedade)
            .WithMany()
            .HasForeignKey(a => a.PropriedadeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pedido>()
    .HasOne(p => p.Avaliacao)
    .WithOne(a => a.Compra)
    .HasForeignKey<Avaliacao>(a => a.PedidoId);
        }
    }
}
