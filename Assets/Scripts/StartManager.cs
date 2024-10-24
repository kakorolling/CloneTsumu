using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{

    public GameObject startBtn;
    public GameObject shadow;
    public GameObject signinWindow;
    public GameObject alertWindow;

    [SerializeField] TMP_InputField emailInput;
    [SerializeField] TMP_InputField pwInput;

    // 인증을 관리할 객체
    Firebase.Auth.FirebaseAuth auth;

    void Awake()
    { 
        // 객체 초기화
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    }

    void Start()
    {
        startBtn.GetComponent<Animator>().Play("StartScene_StartBtn_Show");
        startBtn.SetActive(true);
        shadow.SetActive(false);
        signinWindow.SetActive(false);
        alertWindow.SetActive(false);

    }

    public void PushStartBtn(){
        SoundManager.instance.PlaySESound("DecideBtn");
        startBtn.SetActive(false);
        shadow.SetActive(true);
        signinWindow.SetActive(true);
        
    }

    public void PushBackBtn(){
        SoundManager.instance.PlaySESound("DecideBtn");
        shadow.SetActive(false);
        signinWindow.SetActive(false);
        startBtn.SetActive(true);
    }

    public void PushLoginBtn(){
        SoundManager.instance.PlaySESound("DecideBtn");
        Login();
    }

    public void PushAlertBackBtn(){
        SoundManager.instance.PlaySESound("DecideBtn");
        signinWindow.SetActive(true);
    }

    public void Login()
    {
        // 제공되는 함수 : 이메일과 비밀번호로 로그인 시켜 줌
        auth.SignInWithEmailAndPasswordAsync(emailInput.text, pwInput.text).ContinueWith(
            task => {
                if (task.IsCompleted && !task.IsFaulted && !task.IsCanceled)
                {
                    SceneManager.LoadScene("MainScene");
                    Debug.Log(emailInput.text + " 로 로그인 하셨습니다.");
                }
                else
                {
                    //Debug.Log("로그인 실패");
                    alertWindow.SetActive(true);
                    signinWindow.SetActive(false);
                }
            }
        );
    }
}
