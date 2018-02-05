namespace Origin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sa_role
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string foper_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string frole_no { get; set; }

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
