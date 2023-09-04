using Postgrest.Attributes;
using Postgrest.Models;
using System;

[Table("Accounts")]
public class Accounts : BaseModel
{
    [PrimaryKey("id", false)]
    public int id { get; set; }

    [Column("userID")]
    public string userID { get; set; }

    [Column("status")]
    public string status { get; set; }

    [Column("updated_at")]
    public DateTime updated_at { get; set; }

    public Accounts(int id, string userID, string status)
    {
        this.id = id;
        this.userID = userID;
        this.status = status;
    }

}