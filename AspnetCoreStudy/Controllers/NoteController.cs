using System.Collections.Generic;
using System.Linq;
using AspnetCoreStudy.DataContext;
using AspnetCoreStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreStudy.Controllers
{
    public class NoteController : Controller
    {
        /// <summary>
        /// 게시판 리스트 출력
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //로그인이 안된 상태
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Login","Account");
            }

            var list = new List<Note>();

            using (var db = new AspnetCoreStudyDbContext())
            {
                list = db.Notes.ToList();
            }

                return View(list);
        }

        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            //로그인이 안된 상태
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Login", "Account");
            }


            return View();
        }

        /// <summary>
        /// 게시물 추가 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(Note model)
        {
            model.UserNo = int.Parse(HttpContext.Session.GetInt32("USER_LOGIN_KEY").ToString());


            //입력값 유효성 검사
            if (ModelState.IsValid)
            {

                //DB Insert
                using(var db = new AspnetCoreStudyDbContext())
                {
                    db.Notes.Add(model);

                    //Insert 유효성 검사
                    if(db.SaveChanges() > 0)
                    {
                        //동일 컨트롤러로 리턴
                        return Redirect("Index");
                    }

                    //전역 에러메세지 추가
                    ModelState.AddModelError(string.Empty, "게시물을 저장할 수 없습니다.");
                }
            }

            return View(model);
        }

        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            //로그인이 안된 상태
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        /// <summary>
        /// 게시물 삭제 : 페이지 X
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete()
        {
            //로그인이 안된 상태
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}
