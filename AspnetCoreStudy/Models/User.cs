using System.ComponentModel.DataAnnotations;

namespace AspnetCoreStudy.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        /// 
        [Key]   // PK 설정
        public int No { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required]  // Not Null 설정
        public string Name { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required]  // Not Null 설정
        public string Id { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [Required]  // Not Null 설정
        public string Password { get; set; }

    }
}
