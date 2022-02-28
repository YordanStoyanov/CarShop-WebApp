using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    public class CarsController : Controller
    {
        public CarsController(Request request) 
            : base(request)
        {
        }

        public Response Add()
        {
            return View();
        }

        public Response All()
        {
            return View();
        }
    }
}
