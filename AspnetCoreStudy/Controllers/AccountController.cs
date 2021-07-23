using AspnetCoreStudy.DataContext;
using AspnetCoreStudy.Models;
using AspnetCoreStudy.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreStudy.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 로그인 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            //입력 데이터 유효성 검사
            if (ModelState.IsValid)
            {
                //DB 데이터 검증
                using (var db = new AspnetCoreStudyDbContext())
                {
                    var user = db.Users
                                    .FirstOrDefaultAsync(x => x.Id.Equals(model.UserId) && x.Password.Equals(model.UserPassword));

                    if (user != null)
                    {
                        //로그인 성공 페이지로 이동
                        return RedirectToAction("LoginSuccess","Home");
                    }
                }

                //로그인 실패 시
                ModelState.AddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");
            }
            return View();
        }


        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 회원가입 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(User model)
        {
            //유효성 검사: Model의 Required 값 확인
            if (ModelState.IsValid)
            {
                using(var db = new AspnetCoreStudyDbContext())
                {
                    db.Users.Add(model);    //메모리상의 추가
                    db.SaveChanges();        //Commit
                }

                return RedirectToAction("Index","Home");
            }

            return View(model);
        }

    }
}
