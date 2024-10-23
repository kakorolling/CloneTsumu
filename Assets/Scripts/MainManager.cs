using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    Account account;

    public TMP_Text levelUITxt;
    public TMP_Text CoinUITxt;
    public TMP_Text JewelUITxt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void showNavUI(){
        levelUITxt.text = ((int)account.level).ToString();
        CoinUITxt.text = ((int)account.coin).ToString();
        JewelUITxt.text = ((int)account.jewel).ToString();
    }
}
