using Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels;

public class CreateTodoViewModel
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }

}

public class TodoIndexViewModel
{
    public IEnumerable<Todo> Todos { get; set; }
    public CreateTodoViewModel TodoCreate {  get; set; }

}
