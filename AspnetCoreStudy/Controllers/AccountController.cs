using AspnetCoreStudy.DataContext;
using AspnetCoreStudy.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreStudy.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
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
