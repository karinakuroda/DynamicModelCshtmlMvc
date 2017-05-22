using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppCshtmlDynamic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            dynamic x = new ExpandoObject();
            //x.Teste = "karina";
            x.Teste = new ExpandoObject();
            x.Teste.Name = "karina";
            x.NewProp = string.Empty;
            var expConverter = new ExpandoObjectConverter();
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(@"
            {
            ""Teste"":{
                ""Name"":""karina""
            } ,
            ""FactorInstallmentValue"": 0 
            }", expConverter);

            return View("Index", "", obj);
        
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}