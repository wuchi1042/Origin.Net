namespace Origin.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OriginDbContext : DbContext
    {
        public OriginDbContext()
            : base("name=OriginDbContext")
        {
        }

        public virtual DbSet<t_bi_master> t_bi_master { get; set; }
        public virtual DbSet<t_br_ext> t_br_ext { get; set; }
        public virtual DbSet<t_br_master> t_br_master { get; set; }
        public virtual DbSet<t_br_mr> t_br_mr { get; set; }
        public virtual DbSet<t_br_sv> t_br_sv { get; set; }
        public virtual DbSet<t_bs_br> t_bs_br { get; set; }
        public virtual DbSet<t_sa_role> t_sa_role { get; set; }
        public virtual DbSet<t_sb_master> t_sb_master { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fbom_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.ffresh_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fgive_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fitem_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fitem_no_post)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fitem_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fitem_subno_post)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fitem_clsno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fdpt_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fitem_brdno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fpy_str)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.ftax_rate)
                .HasPrecision(9, 4);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fsale_tax_rate)
                .HasPrecision(9, 4);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.ftax_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fdec_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fcr_oper_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fap_oper_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fig_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fprice_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.flog_mode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fdc_spec_num)
                .HasPrecision(9, 3);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fdc_min_qty)
                .HasPrecision(9, 3);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fdc_num_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fcr_time)
                .HasPrecision(0);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fap_time)
                .HasPrecision(0);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.frowver)
                .IsFixedLength();

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.freward_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.funion_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.ftrans_wms_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.ftrans_web_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.floss_rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.flength)
                .HasPrecision(19, 2);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fwidth)
                .HasPrecision(19, 2);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fheight)
                .HasPrecision(19, 2);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fweight)
                .HasPrecision(19, 2);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fplace)
                .IsUnicode(false);

            modelBuilder.Entity<t_bi_master>()
                .Property(e => e.fclean_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_ext>()
                .Property(e => e.fbrh_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbrh_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fprt_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbg_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fpy_str)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fpos_24hour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbm_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbn_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbe_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbp_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbx_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbk_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbo_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbh_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fjm_rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fpay_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbalance_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fcr_oper_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fap_oper_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fcr_time)
                .HasPrecision(0);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fap_time)
                .HasPrecision(0);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.frowver)
                .IsFixedLength();

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fps_allow)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fbq_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fdc_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.findex)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fmultips_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fstock_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fsale_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fst_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.frd_auto_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.ftrans_wms_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.ftrans_web_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fnotallow_negative_sale)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_br_master>()
                .Property(e => e.fma_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_mr>()
                .Property(e => e.fbrh_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_mr>()
                .Property(e => e.fmr_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_mr>()
                .Property(e => e.frowver)
                .IsFixedLength();

            modelBuilder.Entity<t_br_sv>()
                .Property(e => e.fbrh_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_sv>()
                .Property(e => e.fsv_oper_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_br_sv>()
                .Property(e => e.frowver)
                .IsFixedLength();

            modelBuilder.Entity<t_bs_br>()
                .Property(e => e.fsup_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bs_br>()
                .Property(e => e.fbrh_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bs_br>()
                .Property(e => e.frowver)
                .IsFixedLength();

            modelBuilder.Entity<t_sa_role>()
                .Property(e => e.foper_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sa_role>()
                .Property(e => e.frole_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sa_role>()
                .Property(e => e.fsystem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sa_role>()
                .Property(e => e.frowver)
                .IsFixedLength();

            modelBuilder.Entity<t_sb_master>()
                .Property(e => e.frole_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sb_master>()
                .Property(e => e.frole_clsno)
                .IsUnicode(false);

            modelBuilder.Entity<t_sb_master>()
                .Property(e => e.fsystem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sb_master>()
                .Property(e => e.frowver)
                .IsFixedLength();
        }
    }
}
