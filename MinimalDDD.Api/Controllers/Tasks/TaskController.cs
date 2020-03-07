using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MinimalDDD.Api.Controllers.Tasks
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}