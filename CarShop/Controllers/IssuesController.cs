using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    public class IssuesController : Controller
    {
        public IssuesController(Request request) 
            : base(request)
        {
        }

        public Response Add()
        {
            return View();
        }

        public Response CarIssues()
        {
            return View();
        }
    }
}
