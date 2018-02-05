using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origin.Model
{
    [Table("t_sa_master")]
    public partial class t_sa_master
    {
        public string foper_no { get; set; }

        public string foper_name { get; set; }

        public string foper_brh_no { get; set; }
        public string foper_status { get; set; }


    }
}
