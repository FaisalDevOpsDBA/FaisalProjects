using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVCCoreTest.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger; 
        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
            ViewBag.ExceptionMessage = exceptionHandlerPathFeature.Error.Message;
            ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;

            logger.LogError($"The path {exceptionHandlerPathFeature.Path} threw an exception {exceptionHandlerPathFeature.Error.Message}" );
            return View("Error");
        }
    }
}