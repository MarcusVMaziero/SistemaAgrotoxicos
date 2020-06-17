namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloAgrotoxico : DbContext
    {
        public ModeloAgrotoxico()
            : base("name=ModeloAgrotoxico")
        {
        }

        public virtual DbSet<produto> produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<produto>()
                .Property(e => e.nome)
                .IsUnicode(false);
        }
    }
}
