using Postgrest.Attributes;
using Postgrest.Models;

[Table("User")]

public class User: BaseModel
{
    [Column("parentID")]
    public string parentID { get; set; }

    [Column("name")]
    public string name { get; set; }

}
