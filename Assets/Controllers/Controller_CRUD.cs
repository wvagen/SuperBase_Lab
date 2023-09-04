using Postgrest;
using Postgrest.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Postgrest.QueryOptions;

public class Controller_CRUD
{
    public async void Create(Controller_BaseModel myModel)
    {
        var supabase = await MySupaBase.GetInstance();
        var accountsResult = await supabase.From<Controller_BaseModel>().Insert(myModel, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log(accountsResult.ResponseMessage);
    }

    public async void Update(Controller_BaseModel myModel)
    {
        var supabase = await MySupaBase.GetInstance();
        var accountsResult = await supabase.From<Controller_BaseModel>().Insert(myModel, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log(accountsResult.ResponseMessage);
    }

}
