using System.ComponentModel.DataAnnotations;

namespace aspNetBoard.Models
{
    public class User
    {
        /// <summary>
        /// 사용자번호
        /// </summary>
        [Key]
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자이름
        /// </summary>
        [Required(ErrorMessage ="사용자 이름을 입력하세요")]
        public string UserName { get; set; }

        /// <summary>
        /// 사용자아이디
        /// </summary>
        [Required(ErrorMessage = "사용자 ID를 입력하세요")]
        public string UserId { get; set; }

        /// <summary>
        /// 비밀번호
        /// </summary>
        [Required(ErrorMessage = "비밀번호를 입력하세요")]
        public string Password  { get; set; }
    }
}
