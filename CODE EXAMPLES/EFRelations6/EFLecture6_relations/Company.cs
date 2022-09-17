using System.ComponentModel.DataAnnotations;

public class Company : FullAuditModel
{
[Required]
[StringLength(InventoryModelsConstants.MAX_NAME_LENGTH)]
public string Name { get; set; }
public string Description { get; set; }
public virtual List<Item> Items { get; set; } = new List<Item>();
}