using System.ComponentModel.DataAnnotations;

namespace AspnetCoreStudy.ViewModels
{
    /// <summary>
    /// 로그인시 사용하는 모델
    /// </summary>
    public class LoginViewModel
    {
        [Required(ErrorMessage ="사용자 ID를 입력하세요.")]
        public string UserId { get; set; }

        [Required(ErrorMessage ="비밀번호를 입력하세요.")]
        public string  UserPassword { get; set; }
    }
}
