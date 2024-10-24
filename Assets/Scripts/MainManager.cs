using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    Account account;
    Stage stage;

    public TMP_Text levelUITxt;
    public TMP_Text CoinUITxt;
    public TMP_Text JewelUITxt;


    
    public Sprite selectedScoreBtnImg;
    public Sprite deselectedScoreBtnImg;
    public Image scoreupBtn;
    

    const int MAX_HEART = 5; //최대 하트 수
    const int heartRechargeTime = 8000; //8000초 = 15분

    

    void ShowNavUI(){
        levelUITxt.text = ((int)account.level).ToString();
        CoinUITxt.text = ((int)account.coin).ToString();
        JewelUITxt.text = ((int)account.jewel).ToString();
    }


    void ScoreupSelect(){
        

        
    }
}
