using Postgrest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.PackageManager;
using UnityEngine;
using static Postgrest.QueryOptions;

public class TableInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //InsertTable();
        CreateAccount();
    }
 
    async void InsertTable()
    {
        var accountsModel = new AccountsData
        {
            userID = "mouadh",
            authenticationType = "Phone",
            isPremium = "",
            parentDate= DateTime.UtcNow,    
            updated_at = DateTime.UtcNow,
        };

        Debug.Log(accountsModel.userID);
        var supabase = await MySupaBase.GetInstance();

        var result = await supabase.From<AccountsData>().Insert(accountsModel, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log("Success!");
    }

    private static System.Random random = new System.Random();

    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    async void CreateAccount()
    {
        var supabase = await MySupaBase.GetInstance();

        var accountsModel = new Accounts
        {
            userID = RandomString(5).ToLower(),
            status = "active",
            updated_at = DateTime.UtcNow,
        };

        var accountsResult = await supabase.From<Accounts>().Insert(accountsModel, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log(accountsResult.ResponseMessage);


        var accountsDataModel = new AccountsData
        {
            accountID = accountsResult.Model.id,
            userID = accountsResult.Model.userID,
            isPremium = "hspohttltp@=Gnthpsjvt5O^@:RN^MUaQZ\\__`58=?=89>@>9",
            authenticationType = "Phone",
            parentDate = DateTime.UtcNow,
            parentName = "Taher Mkadmi",
            parentGender = "Male",
            updated_at = DateTime.UtcNow,
        };

        var accountsDataResult = await supabase.From<AccountsData>().Insert(accountsDataModel, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log(accountsDataResult.ResponseMessage);

        var accountChild = new Child
        {
            userID = accountsDataResult.Model.userID,
            name = "Souhaieb",
            surname = "Mkadmi",
            birthDate = new DateTime(1996, 10, 07),
            updated_at = DateTime.UtcNow,
        };

        var accountsChildResult = await supabase.From<Child>().Insert(accountChild, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log(accountsChildResult.ResponseMessage);

        var accountChild1 = new Child
        {
            userID = accountsDataResult.Model.userID,
            name = "Roua",
            surname = "Mkadmi",
            birthDate = new DateTime(1996, 10, 07),
            updated_at = DateTime.UtcNow,
        };

        var accountsChildResult1 = await supabase.From<Child>().Insert(accountChild1, new QueryOptions { Returning = ReturnType.Representation });
        Debug.Log(accountsChildResult1.ResponseMessage);

    }

}
