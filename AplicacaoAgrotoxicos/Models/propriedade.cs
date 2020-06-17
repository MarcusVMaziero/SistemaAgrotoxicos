namespace AplicacaoAgrotoxicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aplicacaoagrotoxicos.propriedade")]
    public partial class propriedade
    {
        public int id { get; set; }

        [StringLength(255)]
        public string nome { get; set; }

        [StringLength(255)]
        public string nome_proprietario { get; set; }

        [StringLength(255)]
        public string endereco { get; set; }
    }
}
