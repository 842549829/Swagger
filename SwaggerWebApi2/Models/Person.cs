using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerWebApi2.Models
{
    /// <summary>
    /// 人
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
    }
}