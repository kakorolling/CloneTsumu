using System.Collections;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject startBtn;
    public GameObject shadow;
    public GameObject signinWindow;

    void Start()
    {
        startBtn.SetActive(false);
        shadow.SetActive(false);
        signinWindow.SetActive(false);
        StartCoroutine("Opening");
    }

    
    IEnumerator Opening(){
        yield return new WaitForSeconds(1f);
        startBtn.SetActive(true);
    }

    public void PushStartBtn(){
        SoundManager.instace.PlaySE("Enter");
        signinWindow.SetActive(true);
        shadow.SetActive(true);
    }

    public void PushBackBtn(){
        SoundManager.instace.PlaySE("Enter");
        signinWindow.SetActive(false);
        shadow.SetActive(false);
        startBtn.SetActive(true);
    }
}
