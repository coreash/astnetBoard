using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspNetBoard.Models
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]
        public int NoteNo { get; set; }

        /// <summary>
        /// 제목
        /// </summary>
        [Required]
        public string NoteTitle { get; set; }

        /// <summary>
        /// 내용
        /// </summary>
        [Required]
        public string NoteContents { get; set; }

        /// <summary>
        /// 작성자
        /// </summary>
        [Required]
        public int UserNo { get; set; }

        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
