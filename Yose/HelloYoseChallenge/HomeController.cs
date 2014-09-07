using System;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using Yose.PingChallenge;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Web;

namespace Yose
{
    public class HomeController: ApiController
    {
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage () {
                Content = new StringContent(GetHomePageContent(), Encoding.UTF8,  "text/html")
            };
        }

        public string GetHomePageContent ()
        {
            string result = string.Empty;

            using (Stream stream = typeof(HomeController).Assembly
                   .GetManifestResourceStream("Yose.HelloYoseChallenge.home.html"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }
            return result;

        }
    }
}