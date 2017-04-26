using Hu.Liang.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu.Liang.Interface
{
    public interface IUser
    {
        ViewUser GetViewUser(string userid);
    }
}
