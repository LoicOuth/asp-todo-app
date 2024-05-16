using Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreatedDate { get; set; }
    [DataType(DataType.Date)]
    public DateTime UpdatedDate { get; set; }
    public TodoStatus Status { get; set; }
}
