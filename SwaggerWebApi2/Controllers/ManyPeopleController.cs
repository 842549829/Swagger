using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SwaggerWebApi2.Models;

namespace SwaggerWebApi2.Controllers
{
    /// <summary>
    /// 众人接口
    /// </summary>
    public class ManyPeopleController : ApiController
    {

        /// <summary>
        /// 获取人的信息
        /// </summary>
        /// <param name="person">人的信息</param>
        /// <returns>结果</returns>
        public string PostPeoples(Person person)
        {
            return "ok";
        }
    }
}