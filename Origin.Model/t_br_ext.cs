namespace Origin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_br_ext
    {
        [Key]
        [StringLength(6)]
        public string fbrh_no { get; set; }

        [Required]
        [StringLength(20)]
        public string fman { get; set; }

        [Required]
        [StringLength(20)]
        public string ftel { get; set; }

        [Required]
        [StringLength(20)]
        public string ffax { get; set; }

        [Required]
        [StringLength(100)]
        public string faddr { get; set; }
    }
}
