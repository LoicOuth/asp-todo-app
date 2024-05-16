using Application.ViewModels;
using Data.Models;

namespace Application.Interfaces;

public interface ITodosService
{
    Task<List<Todo>> All();
    Task Store(CreateTodoViewModel todoViewModel);

}
