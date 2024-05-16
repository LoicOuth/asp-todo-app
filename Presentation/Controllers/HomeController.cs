using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITodosService _todosService;

        public HomeController(ILogger<HomeController> logger, ITodosService todosService)
        {
            _logger = logger;
            _todosService = todosService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _todosService.getAll());
        }
    }
}
