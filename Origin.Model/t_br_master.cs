namespace Origin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_br_master
    {
        [Key]
        [StringLength(6)]
        public string fbrh_no { get; set; }

        [Required]
        [StringLength(30)]
        public string fbrh_name { get; set; }

        [Required]
        [StringLength(10)]
        public string fbrh_subname { get; set; }

        public byte fbrh_type { get; set; }

        [Required]
        [StringLength(6)]
        public string fprt_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbg_no { get; set; }

        public byte flvl_num { get; set; }

        [Required]
        [StringLength(1)]
        public string fstatus { get; set; }

        [Required]
        [StringLength(10)]
        public string fpy_str { get; set; }

        [Required]
        [StringLength(1)]
        public string fpos_24hour { get; set; }

        [Required]
        [StringLength(4)]
        public string fbm_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbn_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbe_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbp_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbx_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbk_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbo_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fbh_no { get; set; }

        public decimal fjm_rate { get; set; }

        [Required]
        [StringLength(1)]
        public string fpay_type { get; set; }

        public decimal fbalance_amt { get; set; }

        [Required]
        [StringLength(6)]
        public string fcr_oper_no { get; set; }

        [Required]
        [StringLength(6)]
        public string fap_oper_no { get; set; }

        [Column(TypeName = "date")]
        public DateTime fcr_date { get; set; }

        public TimeSpan fcr_time { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? fcr_datetime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fap_date { get; set; }

        public TimeSpan? fap_time { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? fap_datetime { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] frowver { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public long? ftransid { get; set; }

        [Required]
        [StringLength(1)]
        public string fps_allow { get; set; }

        [Required]
        [StringLength(4)]
        public string fbq_no { get; set; }

        [Required]
        [StringLength(6)]
        public string fdc_no { get; set; }

        [Required]
        [StringLength(50)]
        public string findex { get; set; }

        [Required]
        [StringLength(1)]
        public string fmultips_type { get; set; }

        [Required]
        [StringLength(1)]
        public string fstock_type { get; set; }

        [Required]
        [StringLength(1)]
        public string fsale_type { get; set; }

        [Required]
        [StringLength(6)]
        public string fst_no { get; set; }

        [Required]
        [StringLength(1)]
        public string frd_auto_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string ftrans_wms_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string ftrans_web_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string fnotallow_negative_sale { get; set; }

        [Required]
        [StringLength(4)]
        public string fma_no { get; set; }
    }
}
