using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using System;

public class GetPlayerAccountInfo
{

    public string _displayName, _avatarUrl, _playFabID, _email;
    public DateTime _createdDate;

    




    public void GetAccountInfo()
    {
        PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest(),
        Result => 
        {
            _displayName = Result.AccountInfo.TitleInfo.DisplayName;
            _avatarUrl = Result.AccountInfo.TitleInfo.AvatarUrl;
            _createdDate = Result.AccountInfo.TitleInfo.Created.Date;
            _playFabID = Result.AccountInfo.PlayFabId;
            _email = Result.AccountInfo.PrivateInfo.Email;

            
        }, 
        Error => 
        { 
        
        
        });
        
    }

    

}
