using Postgrest.Attributes;
using Postgrest.Models;
using System;

[Table(Constants_TableNames.ACCOUNTS_DATA)]
public class Model_AccountsData : Model_BaseModel
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

    public Model_AccountsData() { }
    public Model_AccountsData(int id, int accountID, string userID, string isPremium, string authenticationType,
        DateTime memberShipCreationDate, DateTime parentDate, string parentGender, string parentName)
    {
        this.id = id;
        this.accountID = accountID; 
        this.userID = userID;   
        this.isPremium = isPremium;
        this.authenticationType = authenticationType;
        this.memberShipCreationDate = memberShipCreationDate;
        this.parentDate = parentDate;
        this.parentGender = parentGender;
        this.parentName = parentName;
    }

}
