using Postgrest;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using static Postgrest.QueryOptions;

public class TableInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InsertTable();
    }
 
    async void InsertTable()
    {
        Debug.Log("To Insert Data");
        var parentModel = new AccountsData
        {
            ParentName = "Taher Mkadmi",
        };

        Debug.Log("Step 1");
        var supabase = await MySupaBase.GetInstance();
        Debug.Log("Step 2");

        var result = await supabase.From<AccountsData>().Insert(parentModel, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log(result.Model.ID);

        var childModel = new User
        {
            name = "Mouadh Mkadmi",
            parentID = result.Model.ID,
        };
        await supabase.From<User>().Insert(childModel);

        Debug.Log("Data inserted");
    }

}
