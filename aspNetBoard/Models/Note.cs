﻿using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "제목을 입력하세요")]
        public string NoteTitle { get; set; }

        /// <summary>
        /// 내용
        /// </summary>
        [Required(ErrorMessage = "내용을 입력하세요")]
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
