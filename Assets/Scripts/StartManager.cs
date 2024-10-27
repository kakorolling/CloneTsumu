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
        //startBtn.GetComponent<Animation>().Play();
    }

    public void PushStartBtn(){
        SoundManager.instace.PlaySE("Enter");
        signinWindow.SetActive(true);
        shadow.SetActive(true);
    }
}
