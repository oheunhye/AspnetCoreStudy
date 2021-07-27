using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreStudy.Controllers
{
    public class UploadController : Controller
    {

        private readonly IHostingEnvironment _environment;

        /// <summary>
        /// IHostingEnvironment:환경 추적
        /// </summary>
        /// <param name="envoironment"></param>
        public UploadController(IHostingEnvironment envoironment)
        {
            _environment = envoironment;
        }
        
        /// <summary>
        /// 이미지 업로드
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost, Route("api/upload")]
        public async Task<IActionResult> ImageUpload(IFormFile file)
        {
            //# 이미지나 파일을 업로드할때 필요한 구성
            // 1. Path(경로0 -어디에 저장할지 결정
            var path = Path.Combine(_environment.WebRootPath, "images");

            // 2. Name(파일이름) - DateTime, GUID + GUID(난수)
            // 3. Extension(확장자) - jpg, png, txt..
            string[] strFileFullName = file.FileName.Split('.'); //filename.extension
            string strFileName = $"{Guid.NewGuid()}.{strFileFullName[1]}";

            //server저장
            using (var fileStream = new FileStream(Path.Combine(path, strFileName), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

                return Ok(new { file = $"/image/{strFileName}", success = true });
        }
    }
}
