using TMPro;
using UnityEngine;
using UnityEngine.UI; 

public class ModeChanger : MonoBehaviour
{

    Account account;
    Stage stage; 
    Item item;

    public TMP_Text modeTxt;

    public Sprite selectedScoreupBtnImg;
    public Sprite deselectedScoreupBtnImg;
    public Image scoreupBtn;

    public Sprite selectedCoinupBtnImg;
    public Sprite deselectedCoinupBtnImg;
    public Image coinupBtn;

    public Sprite selectedTimeupBtnImg;
    public Sprite deselectedTimeupBtnImg;
    public Image timeupBtn;

    public Sprite selectedExpupBtnImg;
    public Sprite deselectedExpupBtnImg;
    public Image expupBtn;

    public Sprite selectedComboupBtnImg;
    public Sprite deselectedComboupBtnImg;
    public Image comboupBtn;

    public Sprite selectedFivefourBtnImg;
    public Sprite deselectedFivefourBtnImg;
    public Image fivefourBtn;

    public Sprite selectedNonstopComboBtnImg;
    public Sprite deselectNonstopComboBtnImg;
    public Image nonstopComboBtn;
    
    void ScoreupBtn(){
        if(stage.scoreupMode == false){
            if(account.coin >= 300 || item.scoreupTicket >= 1){
                stage.scoreupMode = true;
                modeTxt.text = "스코어 10% 증가";
                if(item.scoreupTicket == 0) account.coin -= 300;  
                else item.scoreupTicket--;
            }
        }
        
    }
}
