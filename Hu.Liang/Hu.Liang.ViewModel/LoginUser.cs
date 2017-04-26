using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu.Liang.ViewModel
{
    public class LoginUser
    {
        [Required(ErrorMessage="请填写用户名")]
       
        public string Name { get; set; }
         [Required(ErrorMessage = "请填写密码")]
        public string Pwd { get; set; }
         [Required(ErrorMessage = "请填写验证码")]
        public string Code { get; set; }

    }
}
