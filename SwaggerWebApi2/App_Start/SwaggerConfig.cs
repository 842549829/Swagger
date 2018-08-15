using System.Web.Http;
using WebActivatorEx;
using SwaggerWebApi2;
using Swashbuckle.Application;
using System.Reflection;
using System;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SwaggerWebApi2
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "SwaggerWebApi2");

                    //将web层中的注释添加到SwaggerUI中
                    string webXMLPath = string.Format(@"{0}\bin\SwaggerWebApi2.xml", AppDomain.CurrentDomain.BaseDirectory);
                    c.IncludeXmlComments(webXMLPath);

                    //将application层中的注释添加到SwaggerUI中
                    //var serviceXMLPath = string.Format("{0}//bin//SwaggerApiDemo.Application.XML", System.AppDomain.CurrentDomain.BaseDirectory);
                    //c.IncludeXmlComments(serviceXMLPath);

                })
                .EnableSwaggerUi(c =>
                {
                    //加载汉化的js文件，注意 swagger.js文件属性必须设置为“嵌入的资源”。
                    c.InjectJavaScript(Assembly.GetExecutingAssembly(), "SwaggerWebApi2.SwaggerUI.swaggerTranslator.js");
                });
        }
    }
}
