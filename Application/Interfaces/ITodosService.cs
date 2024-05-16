using Data.Models;

namespace Application.Interfaces;

public interface ITodosService
{
    Task<List<Todo>> getAll();
}
