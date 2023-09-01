using Postgrest.Attributes;
using Postgrest.Models;
using System;

[Table("Accounts")]
public class Accounts : BaseModel
{
    [PrimaryKey("userID")]
    public string userID { get; set; }

    [Column("status")]
    public string status { get; set; }

    [Column("updated_at")]
    public DateTime updated_at { get; set; }

}