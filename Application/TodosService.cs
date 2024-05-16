using Application.Interfaces;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Application;

public class TodosService : ITodosService
{
    private readonly ApplicationDbContext _context;

    public TodosService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Todo>> getAll()
    {
        return await _context.Todos.OrderBy(t => t.CreatedDate).ToListAsync();
    }
}
