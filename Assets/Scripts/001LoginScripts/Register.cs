using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    RegisterBase _registerBase;
    LoginBase _loginBase;
    
    [SerializeField] InputField _email, _password , _username;
    [SerializeField] GameObject _asyncPanel;
    [SerializeField] Text _asyncInfoText;
    [SerializeField] string url;

    private void Awake()
    {
        _registerBase = new RegisterBase();
        _loginBase = new LoginBase();
        
    }

    public void RegisterOnClick()
    {

        StartCoroutine(RegisterAsyncControl());

    }


    public void LoginOnClick()
    {
        StartCoroutine(LoginAsyncControl());
    }


    IEnumerator RegisterAsyncControl()
    {
        _asyncPanel.SetActive(true);
        _asyncInfoText.text = "Kayıt Oluşturuluyor..";
        _registerBase.RegisterEmail(_email, _password, _username);
        yield return new WaitUntil(() => _registerBase.RegisterBase_Async);
        

        _asyncInfoText.text = "Kayıt Oluşturuluyor..";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);


    }

    IEnumerator LoginAsyncControl()
    {
        _asyncPanel.SetActive(true);
        _asyncInfoText.text = "Kayıt Oluşturuluyor..";
        _loginBase.LoginOnClick(_email, _password);
        yield return new WaitUntil(() => _loginBase.LoginBase_Async);


        _asyncInfoText.text = "Kayıt Oluşturuluyor..";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);


    }

}
