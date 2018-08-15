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

                    //��web���е�ע����ӵ�SwaggerUI��
                    string webXMLPath = string.Format(@"{0}\bin\SwaggerWebApi2.xml", AppDomain.CurrentDomain.BaseDirectory);
                    c.IncludeXmlComments(webXMLPath);

                    //��application���е�ע����ӵ�SwaggerUI��
                    //var serviceXMLPath = string.Format("{0}//bin//SwaggerApiDemo.Application.XML", System.AppDomain.CurrentDomain.BaseDirectory);
                    //c.IncludeXmlComments(serviceXMLPath);

                })
                .EnableSwaggerUi(c =>
                {
                    //���غ�����js�ļ���ע�� swagger.js�ļ����Ա�������Ϊ��Ƕ�����Դ����
                    c.InjectJavaScript(Assembly.GetExecutingAssembly(), "SwaggerWebApi2.SwaggerUI.swaggerTranslator.js");
                });
        }
    }
}
