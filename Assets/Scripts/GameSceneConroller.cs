using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneConroller : MonoBehaviour
{

    GetPlayerAccountInfo _getPlayerAccountInfo;
    [SerializeField] TextMeshPro _playerName;



    private void Awake()
    {
        _getPlayerAccountInfo = new GetPlayerAccountInfo();
        _getPlayerAccountInfo.GetAccountInfo();


        _playerName.text = _getPlayerAccountInfo._displayName;


    }





}
