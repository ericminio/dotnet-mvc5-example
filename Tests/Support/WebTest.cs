using System;
using NUnit.Framework;
using System.Web.Http;
using Yose;
using System.Net.Http;

namespace Tests
{
    public class WebTest
    {
        protected HttpClient client;

        [SetUp]
        public void ConnectTotheServer ()
        {
            var config = new HttpConfiguration();                       
            MvcApplication.RegisterRoutes (config);
            var server = new HttpServer(config);

            client = new HttpClient(server);
        }
    }
}