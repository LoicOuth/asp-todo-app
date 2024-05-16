using System.ComponentModel.DataAnnotations;

namespace Data.Models.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    [Display(Name = "Created date")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate { get; set; }
    [Display(Name = "Updated date")]
    [DataType(DataType.Date)]
    public DateTime? UpdatedDate { get; set; }
}
