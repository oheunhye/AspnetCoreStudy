using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetCoreStudy.Models
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]
        public int No { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required]
        public string Contents { get; set; }

        /// <summary>
        /// 작성자
        /// </summary>
        [Required]
        public int UserNo { get; set; }


        //JOIN 설정
        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
