using Hu.Liang.EF;
using Hu.Liang.Interface;
using Hu.Liang.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Hu.Liang.Server
{
    public class UserServer : IUser
    {
        public ViewUser GetViewUser(string userid)
        {
            using (var context = new HuLiang())
            {
                var u = context.Base_User.First(c => c.UserId == userid);
                if (u != null)
                {
                    return new ViewUser
                    {
                        UserId = u.UserId,
                        Account = u.Account,
                        Gender = u.Gender,
                        Mobile = u.Mobile,
                        Email = u.Email

                    };
                }
            }
            return null;
        }
    }
}
