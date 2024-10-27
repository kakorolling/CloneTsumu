using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    Account account;

    public TMP_Text levelTxtUI;
    public TMP_Text coinTxtUI;
    public TMP_Text jewelTxtUI;


    void Awake(){
        levelTxtUI.text = ((int)account.level).ToString();
        coinTxtUI.text = ((int)account.coin).ToString();
        jewelTxtUI.text = ((int)account.jewel).ToString();
    }

    public void PushCoinAddBtn(){

    }

    public void PushJewelAddBtn(){
        
    }
}
