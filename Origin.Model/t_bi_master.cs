namespace Origin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bi_master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fitem_id { get; set; }

        [Required]
        [StringLength(1)]
        public string fstatus { get; set; }

        [Required]
        [StringLength(1)]
        public string fbom_type { get; set; }

        [Required]
        [StringLength(1)]
        public string ffresh_type { get; set; }

        [Required]
        [StringLength(1)]
        public string fgive_type { get; set; }

        [Required]
        [StringLength(15)]
        public string fitem_no { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8)]
        public string fitem_no_post { get; set; }

        [Required]
        [StringLength(20)]
        public string fitem_subno { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8)]
        public string fitem_subno_post { get; set; }

        [Required]
        [StringLength(50)]
        public string fitem_name { get; set; }

        [Required]
        [StringLength(10)]
        public string fitem_subname { get; set; }

        [Required]
        [StringLength(15)]
        public string fitem_size { get; set; }

        [Required]
        [StringLength(6)]
        public string fitem_clsno { get; set; }

        [Required]
        [StringLength(6)]
        public string fdpt_no { get; set; }

        [Required]
        [StringLength(4)]
        public string fitem_brdno { get; set; }

        [Required]
        [StringLength(10)]
        public string fpy_str { get; set; }

        [Required]
        [StringLength(4)]
        public string funit_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ftax_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fsale_tax_rate { get; set; }

        [Required]
        [StringLength(1)]
        public string ftax_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string fdec_flag { get; set; }

        [Required]
        [StringLength(6)]
        public string fcr_oper_no { get; set; }

        [Required]
        [StringLength(6)]
        public string fap_oper_no { get; set; }

        public int fexp_date { get; set; }

        [Required]
        [StringLength(1)]
        public string fig_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string fprice_type { get; set; }

        [Required]
        [StringLength(1)]
        public string flog_mode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fdc_spec_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fdc_min_qty { get; set; }

        [Required]
        [StringLength(1)]
        public string fdc_num_flag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fcr_date { get; set; }

        public TimeSpan? fcr_time { get; set; }

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
        public string freward_type { get; set; }

        public int freward_item_id { get; set; }

        [Required]
        [StringLength(1)]
        public string funion_flag { get; set; }

        public byte fig_num { get; set; }

        [Required]
        [StringLength(1)]
        public string ftrans_wms_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string ftrans_web_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? floss_rate { get; set; }

        public decimal flength { get; set; }

        public decimal fwidth { get; set; }

        public decimal fheight { get; set; }

        public decimal fweight { get; set; }

        [Required]
        [StringLength(40)]
        public string fplace { get; set; }

        public short fpo_spec_num { get; set; }

        public int freturn_day_num { get; set; }

        public int? fpo_day_num { get; set; }

        [Required]
        [StringLength(1)]
        public string fclean_flag { get; set; }

        public short fclean_period { get; set; }
    }
}
