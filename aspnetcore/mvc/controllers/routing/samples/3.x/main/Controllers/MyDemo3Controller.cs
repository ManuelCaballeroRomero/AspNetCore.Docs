﻿//#define MYDEMO3

using Microsoft.AspNetCore.Mvc;

// This uses same routes as HomeController, so only one can be defined without setting order
// Test with                     webBuilder.UseStartup<StartupDefaultMVC>();
// or with StartupMap
namespace WebMvcRouting.Controllers
{
#if MYDEMO3
    #region snippet2
    public class MyDemo3Controller : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/MyIndex")]
        public IActionResult MyIndex()
        {
            return Content("MyIndex");
        }   
    }
    #endregion
#else
    #region snippet3
    public class MyDemo3Controller : Controller
    {
        [Route("")]
        [Route("Home",Order = 2)]
        [Route("Home/MyIndex")]
        public IActionResult MyIndex()
        {
            return Content("MyIndex");
        }
    }
    #endregion
#endif
}

