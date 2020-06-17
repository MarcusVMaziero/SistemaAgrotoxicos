namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aplicacaoagrotoxicos.usuario")]
    public partial class usuario
    {
        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string login { get; set; }

        [Required]
        [StringLength(45)]
        public string senha { get; set; }
    }
}
