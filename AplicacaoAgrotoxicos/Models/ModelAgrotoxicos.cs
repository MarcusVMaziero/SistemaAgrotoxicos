namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelAgrotoxicos : DbContext
    {
        public ModelAgrotoxicos()
            : base("name=ModelAgrotoxicos")
        {
        }

        public virtual DbSet<aplicacao> aplicacao { get; set; }
        public virtual DbSet<exemplo> exemplo { get; set; }
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<propriedade> propriedade { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<exemplo>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .HasOptional(e => e.aplicacao)
                .WithRequired(e => e.produto);

            modelBuilder.Entity<propriedade>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<propriedade>()
                .Property(e => e.nome_proprietario)
                .IsUnicode(false);

            modelBuilder.Entity<propriedade>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.senha)
                .IsUnicode(false);
        }
    }
}
