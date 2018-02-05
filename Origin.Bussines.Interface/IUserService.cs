using Origin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origin.Bussines.Interface
{
    public interface IUserService:IBaseSevice
    {
        List<t_bi_master> GetUser();
    }
}
