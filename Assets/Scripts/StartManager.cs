using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public GameObject startBtn;
    public GameObject shadow;
    public GameObject signinWindow;

    [SerializeField] TMP_InputField emailField;
    [SerializeField] TMP_InputField passField;

    Firebase.Auth.FirebaseAuth auth;

    void Awake()
    { 
        // 객체 초기화
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    }

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

    public void PushSigninBtn(){
        Login();
    }

    public void PushBackBtn(){
        SoundManager.instace.PlaySE("Enter");
        signinWindow.SetActive(false);
        shadow.SetActive(false);
        startBtn.SetActive(true);
    }

    public void Login()
    {   
        // 제공되는 함수 : 이메일과 비밀번호로 로그인 시켜 줌
        auth.SignInWithEmailAndPasswordAsync(emailField.text, passField.text).ContinueWith(
            task => {
                if (task.IsCompleted && !task.IsFaulted && !task.IsCanceled)
                {
                    Debug.Log(emailField.text + " 로 로그인 하셨습니다.");
                    SceneManager.LoadScene("MainScene");
                }
                else
                {
                    Debug.Log("로그인에 실패하셨습니다.");
                }
            }
        );
    }
}
    
    