namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aplicacaoagrotoxicos.exemplo")]
    public partial class exemplo
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string nome { get; set; }
    }
}
