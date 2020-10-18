using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Crossroads.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly ILogger<ArtistsController> _logger;

        public ArtistsController(ILogger<ArtistsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
