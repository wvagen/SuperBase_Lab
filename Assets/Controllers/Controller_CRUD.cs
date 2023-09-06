using Postgrest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static Postgrest.QueryOptions;

public class Controller_CRUD : Model_BaseModel
{
    static Controller_CRUD instance;

    public static Controller_CRUD Get_Instance()
    {
        if (instance == null) { instance = new Controller_CRUD(); }

        return instance;
    }

    public async Task Create(Model_BaseModel myModel, string userID = "unknown")
    {
        var supabase = await MySupaBase.GetInstance();

        var logTableInstance = new Model_Log
        {
            userID = userID,
        };

        logTableInstance.logMsg = "Inserting " + myModel.ToString();
        logTableInstance.logType = Model_Log.LOG_TYPE.INFO.ToString();

        await supabase.From<Model_Log>().Insert(logTableInstance, new QueryOptions { Returning = ReturnType.Representation });

        try
        {
            var operationResult = await supabase.From<Model_BaseModel>().Insert(myModel, new QueryOptions { Returning = ReturnType.Representation });

            Debug.Log(operationResult.ResponseMessage);

            logTableInstance.logMsg = operationResult.ResponseMessage.ToString();
            logTableInstance.logType = Model_Log.LOG_TYPE.SUCCESS.ToString();

            await supabase.From<Model_Log>().Insert(logTableInstance, new QueryOptions { Returning = ReturnType.Representation });

        }

        catch (Exception ex)
        {
            Debug.Log(ex.Message);

            logTableInstance.logMsg = ex.Message;
            logTableInstance.logType = Model_Log.LOG_TYPE.ERROR.ToString();

            await supabase.From<Model_Log>().Insert(logTableInstance, new QueryOptions { Returning = ReturnType.Representation });

        }

    }

    //public async void Update(Model_BaseModel myModel)
    //{
    //    var supabase = await MySupaBase.GetInstance();
    //    var accountsResult = await supabase.From<Controller_BaseModel>().Insert(myModel, new QueryOptions { Returning = ReturnType.Representation });
    //    Debug.Log(accountsResult.ResponseMessage);
    //}
}
