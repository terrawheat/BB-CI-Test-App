using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CITest.Controllers
{
    public class TestController : ApiController
    {
        // GET: /<controller>/
        public IActionResult GetData()
        {
            return Ok(new
            {
                Foo = "Bar",
                Baz = 1
            });
        }
    }
}
