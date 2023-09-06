using Postgrest.Attributes;
using Postgrest.Models;
using System;

[Table("Child")]
public class Model_Child : BaseModel
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

    public Model_Child() { }

    public Model_Child(int id, string userID, int childIndex, string achivementsUnlocked, DateTime birthDate,
        string dictionnaryWordsUnlocked, string downBodyAccessoriesOwned, string downBodyAccessoriesWeared, 
        string gender, string keysUnlocked,string levelReached,string name,string starsCollected, string surname, 
        string upperBodyAccessoriesOwned,string upperBodyAccessoriesWeared)
    {
        this.id = id;
        this.userID = userID;
        this.childIndex = childIndex;
        this.achivementsUnlocked = achivementsUnlocked;
        this.birthDate = birthDate;
        this.dictionnaryWordsUnlocked = dictionnaryWordsUnlocked;
        this.downBodyAccessoriesOwned = downBodyAccessoriesOwned;
        this.downBodyAccessoriesWeared= downBodyAccessoriesWeared;
        this.gender = gender;
        this.keysUnlocked = keysUnlocked;
        this.levelReached = levelReached;
        this.name = name;
        this.starsCollected= starsCollected;
        this.surname = surname;
        this.upperBodyAccessoriesOwned = upperBodyAccessoriesOwned;
        this.upperBodyAccessoriesWeared = upperBodyAccessoriesWeared;
    }
}
