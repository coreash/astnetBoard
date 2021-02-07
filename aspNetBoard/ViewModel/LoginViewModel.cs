using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetBoard.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="사용자 아이디를 입력하세요")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력하세요")]
        public string Password { get; set; }
    }
}
