using System;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using Yose.PingChallenge;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;

namespace Yose
{
    public class HomeController: ApiController
    {
        public HttpResponseMessage Get()
        {
            var html = File.ReadAllText ("HelloYoseChallenge/home.html");
            return new HttpResponseMessage () {
                Content = new StringContent(html, Encoding.UTF8,  "text/html")
            };
        }
    }
}

