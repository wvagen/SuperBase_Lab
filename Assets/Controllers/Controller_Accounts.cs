using Postgrest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Postgrest.QueryOptions;

public class Controller_Accounts : MonoBehaviour
{

    public async void CreateAccount(string userID)
    {
        var supabase = await MySupaBase.GetInstance();

        var accountsModel = new Model_Accounts
        {
            userID = userID,
            status = "active",
        };

        try
        {
            var accountsResult = await supabase.From<Model_Accounts>().Insert(accountsModel, new QueryOptions { Returning = ReturnType.Representation });
            Debug.Log(accountsResult.ResponseMessage);
        }
        catch(Exception ex) {
            Debug.Log(ex.Message);
        }


    }
}
