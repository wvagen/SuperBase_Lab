using Postgrest.Attributes;
using Postgrest.Models;
using System;


[Table("Log")]
public class Model_Log : BaseModel
{
    [PrimaryKey("id", false)]
    public int id { get; set; }

    [Column("userID")]
    public string userID { get; set; }

    [Column("logType")]
    public string logType { get; set; }


    [Column("logMsg")]
    public string logMsg { get; set; }

}
