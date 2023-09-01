using Postgrest.Attributes;
using Postgrest.Models;
using System;

[Table("Child")]
public class Child : BaseModel
{
    [PrimaryKey("id", false)]
    public int id { get; set; }

    [Column("userID")]
    public string userID { get; set; }

    [Column("childIndex")]
    public int childIndex { get; set; }

    [Column("achivementsUnlocked")]
    public string achivementsUnlocked { get; set; }

    [Column("birthDate")]
    public DateTime birthDate { get; set; }

    [Column("dictionnaryWordsUnlocked")]
    public string dictionnaryWordsUnlocked { get; set; }

    [Column("downBodyAccessoriesOwned")]
    public string downBodyAccessoriesOwned { get; set; }

    [Column("downBodyAccessoriesWeared")]
    public string downBodyAccessoriesWeared { get; set; }

    [Column("gender")]
    public string gender { get; set; }

    [Column("keysUnlocked")]
    public string keysUnlocked { get; set; }

    [Column("levelReached")]
    public string levelReached { get; set; }

    [Column("name")]
    public string name { get; set; }

    [Column("starsCollected")]
    public string starsCollected { get; set; }

    [Column("surname")]
    public string surname { get; set; }

    [Column("upperBodyAccessoriesOwned")]
    public string upperBodyAccessoriesOwned { get; set; }

    [Column("upperBodyAccessoriesWeared")]
    public string upperBodyAccessoriesWeared { get; set; }

    [Column("updated_at")]
    public DateTime updated_at { get; set; }

}
