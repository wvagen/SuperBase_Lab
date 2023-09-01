using Postgrest.Attributes;
using Postgrest.Models;
using System;

[Table("AccountsData")]
public class AccountsData : BaseModel
{
    [PrimaryKey("id",false)]
    public int id { get; set; }

    [Column("accountID")]
    public int accountID { get; set; }

    [Column("userID")]
    public string userID { get; set; }

    [Column("isPremium")]
    public string isPremium { get; set; }

    [Column("authenticationType")]
    public string authenticationType { get; set; }

    [Column("memberShipCreationDate")]
    public DateTime memberShipCreationDate { get; set; }

    [Column("parentDate")]
    public DateTime parentDate { get; set; }

    [Column("parentGender")]
    public string parentGender { get; set; }

    [Column("parentName")]
    public string parentName { get; set; }

    [Column("updated_at")]
    public DateTime updated_at { get; set; }
}
