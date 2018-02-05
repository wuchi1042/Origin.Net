using Origin.Bussines.Interface;
using Origin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origin.Bussines.Service
{
    public class UserService : BaseService, IUserService
    {

        public List<t_bi_master> GetUser()
        {
            string sql = @"select * from t_bi_master";
            using (IUserService userService = new UserService())
            {
                List<t_bi_master> list = userService.FindIQueryable<t_bi_master>().ToList();
                return list;
            }
           
        }
        
    }
}
