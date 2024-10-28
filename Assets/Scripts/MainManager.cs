using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    Account account;
    
    public TMP_Text levelTxtUI;
    public TMP_Text coinTxtUI;
    public TMP_Text jewelTxtUI;
    public TMP_Text nickNameTxtUI;

    public UnityEngine.UI.Image[] heartsUI;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Awake(){
        

        levelTxtUI.text = "3";
        //coinTxtUI.text = 
        //jewelTxtUI.text = 
        //nickNameTxtUI.text = 
    }
    
    void Start(){
        Debug.Log(account.level);
    }
    void Update(){
        Heart();
    }
    public void PushCoinAddBtn(){

    }

    public void PushJewelAddBtn(){
        
    }

    void Heart(){
        for(int i = 0; i < heartsUI.Length; i++){

            if(i < account.heart){
                heartsUI[i].sprite = fullHeart;
            }else{
                heartsUI[i].sprite = emptyHeart;
            }

            if(i < account.numOfHearts){
                heartsUI[i].enabled = true;
            } else{
                heartsUI[i].enabled = false;
            }
        }
    }
    
}
