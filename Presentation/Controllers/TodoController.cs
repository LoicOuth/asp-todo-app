using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;

namespace Presentation.Controllers
{
    public class TodoController : Controller
    {
        private readonly ILogger<TodoController> _logger;
        private readonly ITodosService _todosService;

        public TodoController(ILogger<TodoController> logger, ITodosService todosService)
        {
            _logger = logger;
            _todosService = todosService;
        }

        public async Task<IActionResult> Index()
        {
            TodoIndexViewModel todoIndexViewModel = new()
            {
                Todos = await _todosService.All()
            };

            return View(todoIndexViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Store(CreateTodoViewModel todo)
        {
            await _todosService.Store(todo);

            return RedirectToAction(nameof(Index));
        }
    }
}
