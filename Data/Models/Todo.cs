using Data.Enums;
using Data.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Todo : BaseAuditableEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public TodoStatus Status { get; set; }
}
