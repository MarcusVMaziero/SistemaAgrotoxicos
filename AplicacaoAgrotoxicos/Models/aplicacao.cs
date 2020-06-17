namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aplicacaoagrotoxicos.aplicacao")]
    public partial class aplicacao
    {
        public int id { get; set; }

        public double hecitares { get; set; }

        public int fk_produto { get; set; }

        [Column(TypeName = "date")]
        public DateTime dataLimite { get; set; }

        public virtual produto produto { get; set; }
    }
}
