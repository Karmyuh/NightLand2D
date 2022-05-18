using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;

public class LoginBase
{
    public bool LoginBase_Async { get; set; }

    public void LoginOnClick(InputField _email , InputField _password)
    {
        PlayFabClientAPI.LoginWithEmailAddress(new LoginWithEmailAddressRequest() {Email = _email.text , Password = _password.text}, 
            Result => 
            {
                SceneManager.LoadScene(1);
                LoginBase_Async = true;
            }, 
            Error => 
            {
                Debug.Log("Giriş Başarısız");
                LoginBase_Async = false;
            });
    }
}
