using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Core;
using CRM.Core.ORM;
using CRM.Core.Entities;

namespace CRM.Data.Concrete
{
    public interface ITrans_UserInfoMasterRepository
    {
        Trans_UserInfo GetUSerByUserNameAndPwd(string userName, string password);
    }


    public class Trans_UserInfoMasterRepository : ITrans_UserInfoMasterRepository
    {
        private readonly CRMDbContext _dbContext;

        public Trans_UserInfoMasterRepository()
        {
            _dbContext = new CRMDbContext();
        }
        public Trans_UserInfo GetUSerByUserNameAndPwd(string userName, string password)
        {
            return _dbContext.Trans_UserInfoMaster
                   .FirstOrDefault(u => u.UserName == userName
                   && u.Password == password);
        }
    }
}
