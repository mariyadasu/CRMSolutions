using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Data.Concrete;

namespace CRM.Service.Authentication
{
    public interface IAuthenticationService
    {
        bool CheckUserByUserNameAndPwd(string userName, string Password);
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly ITrans_UserInfoMasterRepository _iTrans_UserInfoMasterRepository;
        public AuthenticationService(ITrans_UserInfoMasterRepository iTrans_UserInfoMasterRepository)
        {
            _iTrans_UserInfoMasterRepository = iTrans_UserInfoMasterRepository;
        }
        public bool CheckUserByUserNameAndPwd(string userName, string Password)
        {
            var userInfo = _iTrans_UserInfoMasterRepository.GetUSerByUserNameAndPwd(userName, Password);
            return userInfo == null ? false : true;
        }
    }
}
