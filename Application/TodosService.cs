using Application.Interfaces;
using Application.ViewModels;
using Data;
using Data.Enums;
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

    public async Task<List<Todo>> All()
    {
        return await _context.Todos.OrderByDescending(t => t.CreatedDate).ToListAsync();
    }
    public async Task Store(CreateTodoViewModel todoViewModel)
    {
        Todo todo = new Todo() 
        { 
            Title = todoViewModel.Title, 
            Description = todoViewModel.Description, 
            Status = TodoStatus.NotStarted
        };
        _context.Todos.Add(todo);

        await _context.SaveChangesAsync();
    }
}
