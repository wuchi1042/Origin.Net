namespace Origin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_br_sv
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string fbrh_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short fline_id { get; set; }

        [Required]
        [StringLength(6)]
        public string fsv_oper_no { get; set; }

        [Required]
        [StringLength(20)]
        public string fsv_tel { get; set; }

        [Required]
        [StringLength(20)]
        public string fsv_cn { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] frowver { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public long? ftransid { get; set; }
    }
}
