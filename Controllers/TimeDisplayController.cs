using Microsoft.AspNetCore.Mvc;
using System;

namespace DojoSurvey.Controllers

{
    public class TimeDisplayController:Controller
    {
        [HttpGet("")]

        public IActionResult Index()
        {
            return View();
        }

    }
}