namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelExemplo : DbContext
    {
        public ModelExemplo()
            : base("name=ModelExemplo")
        {
        }

        public virtual DbSet<exemplo> exemplo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<exemplo>()
                .Property(e => e.nome)
                .IsUnicode(false);
        }
    }
}
