using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace LibraryApplication.Library
{
    public class CommonLibrary
    {
        public string GetUrl(string strType)
        {
            string strReturnValue = string.Empty;

            switch (strType)
            {
                case "full":
                    strReturnValue = HttpContext.Request.PathBase;
                    break;
            }

            return strReturnValue;
        }

        public List<UrlParameter> UrlParameters
        {
            get {
                    List<UrlParameter> lstReturnValue = new List<UrlParameter>();
                    string[] arrParam = new string[] { };


                    string strUrl = this.GetUrl("full");

                    //url과 파라미터 나누기
                    string[] arrUrl = strUrl.Split('?');


                    if (arrUrl.Length > 1)
                    {
                        //복수 파라미터 나누기
                        arrParam = arrUrl[1].Split('&');

                        //파라미터 이름과 값 나누기
                        foreach (string item in arrParam)
                        {
                            UrlParameter param = new UrlParameter()
                            {
                                Key = item.Split('=')[0],   //이름
                                Value = item.Split('=')[1]  //값
                            };

                            lstReturnValue.Add(param);
                        }
                    }
                    
                    return lstReturnValue;  
            }
        }

        //URL 매개변수 중복제거
        public string AddUrlParameter(string strKey, string strValue)
        {
            string strReturnValue = string.Empty;

            List<UrlParameter> lstUrlParam = this.UrlParameters;
            UrlParameter param = lstUrlParam.Where(x => x.Key == strKey).SingleOrDefault();

            if(param != null)
            {
                lstUrlParam.Remove(param);
            }

            lstUrlParam.Add(new UrlParameter()
            {
                Key = strKey,
                Value = strValue
            });

            for(int i = 0; i < lstUrlParam.Count(); i++)
            {
                strReturnValue += i == 0 ? "?" : "&";
                strReturnValue += lstUrlParam[i].Key + "=" + lstUrlParam[i].Value;
            }

            return strReturnValue;
        }
    }
}
