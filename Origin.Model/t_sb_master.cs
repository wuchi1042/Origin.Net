namespace Origin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sb_master
    {
        [Key]
        [StringLength(4)]
        public string frole_no { get; set; }

        [Required]
        [StringLength(20)]
        public string frole_name { get; set; }

        [Required]
        [StringLength(200)]
        public string frole_desc { get; set; }

        [Required]
        [StringLength(2)]
        public string frole_clsno { get; set; }

        [Required]
        [StringLength(10)]
        public string frole_type { get; set; }

        [Required]
        [StringLength(1)]
        public string fsystem { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] frowver { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public long? ftransid { get; set; }
    }
}
