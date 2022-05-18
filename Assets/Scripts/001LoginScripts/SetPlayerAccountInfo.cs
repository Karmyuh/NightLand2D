using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class SetPlayerAccountInfo 
{

    #region AVATAR
    public void SetProfilAvatar(string URL)
    {


        PlayFabClientAPI.UpdateAvatarUrl(new UpdateAvatarUrlRequest()
        {

            ImageUrl = URL

        },
        Result =>
        {

            Debug.Log("Görsel Yüklendi");

        },
        Error =>
        {
            Debug.Log("Görsel Yüklenmedi..");
        });
    } 
    #endregion




}
