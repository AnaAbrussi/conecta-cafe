using ConectaCafe.Models;
using Microsoft.EntityFrameworkCore;

namespace ConectaCafe.Data;

    public class AppDbContext : DbContext 
    {   
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {      
        }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
         public DbSet<Tag> Tags { get; set; }


    protected override void OnModelCreating(ModelBuilder Builder)
    {
        base.OnModelCreating(Builder);

        // FluentAPI
        #region muitos para muitos do BlogTag
        Builder.Entity<BlogTag>().HasKey(
            bt => new { bt.BlogId, bt.TagId }
        );
        Builder.Entity<BlogTag>()
            .HasOne(bt => bt.Blog)
            .WithMany(b => b.BlogTags)
            .HasForeignKey(bt => bt.BlogId);

        Builder.Entity<BlogTag>()
            .HasOne(bt => bt.Tag)
            .WithMany(t => t.BlogTags)
            .HasForeignKey(bt => bt.TagId);

        #endregion

    }

}