using Postgrest.Attributes;
using Postgrest.Models;
using System;

[Table("Accounts")]
public class Model_Accounts : Model_BaseModel
{
    [PrimaryKey("id", false)]
    public int id { get; set; }

    [Column("userID")]
    public string userID { get; set; }

    [Column("status")]
    public string status { get; set; }

    [Column("updated_at")]
    public DateTime updated_at { get; set; }

    public Model_Accounts() { }

    public Model_Accounts(int id, string userID, string status)
    {
        this.id = id;
        this.userID = userID;
        this.status = status;
    }

    public Model_Accounts(string userID, string status)
    {
        this.userID = userID;
        this.status = status;
    }


}