namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aplicacaoagrotoxicos.produto")]
    public partial class produto
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string nome { get; set; }

        public virtual aplicacao aplicacao { get; set; }
    }
}
