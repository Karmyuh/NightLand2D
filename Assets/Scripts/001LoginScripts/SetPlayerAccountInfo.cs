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

            Debug.Log("G�rsel Y�klendi");

        },
        Error =>
        {
            Debug.Log("G�rsel Y�klenmedi..");
        });
    } 
    #endregion




}
