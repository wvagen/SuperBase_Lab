using Postgrest.Attributes;
using Postgrest.Models;

[Table("Accounts")]
public class AccountsData : BaseModel
{
    [PrimaryKey("id",false)]
    public string ID { get; set; }

    [Column("parentName")]
    public string ParentName { get; set; }

}
