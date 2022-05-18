using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using System;

public class RegisterBase
{
    public bool RegisterBase_Async { get; set; }
    public void RegisterEmail(InputField _email, InputField _password, InputField _username)
    {
        //RegisterPlayFabUserRequest _register = new RegisterPlayFabUserRequest();
        //_register.Email = _email.text;
        //_register.Password = _password.text;
        //_register.Username = _username.text;

        //PlayFabClientAPI.RegisterPlayFabUser(_register, Success, Error);                  -- UZUN YOL


        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest()
        {
            Email = _email.text,
            Password = _password.text,
            Username = _username.text,
            DisplayName = _username.text


        },
            Result =>
            {
                Debug.Log("Kayıt Başarılı..");
                RegisterBase_Async = true;
            },
            Error =>
            {
                RegisterBase_Async = false;
            });
    }

    //private void Error(PlayFabError obj)
    //{
    //    Debug.Log("Kayıt Başarısız..");
    //}

    //private void Success(RegisterPlayFabUserResult obj)
    //{
    //    Debug.Log("Kayıt Başarılı..");
    //}


}
