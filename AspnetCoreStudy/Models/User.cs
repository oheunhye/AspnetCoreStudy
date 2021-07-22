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
        [Required(ErrorMessage ="사용자 이름을 입력하세요.")]  // Not Null 설정
        public string Name { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required(ErrorMessage ="사용자 ID를 입력하세요.")]  // Not Null 설정
        public string Id { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [Required(ErrorMessage ="비밀번호를 입력하세요.")]  // Not Null 설정
        public string Password { get; set; }

    }
}
