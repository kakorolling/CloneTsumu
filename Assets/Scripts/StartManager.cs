using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{

    public GameObject startBtn;

    public GameObject shadow;
    public GameObject signinWindow;

    [SerializeField] InputField emailField;
    [SerializeField] InputField pwField;

    // 인증을 관리할 객체
    Firebase.Auth.FirebaseAuth auth;

    void Awake()
    { 
        // 객체 초기화
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    }

    void Start()
    {
        startBtn.SetActive(true);
        shadow.SetActive(false);
        signinWindow.SetActive(true);

    }

    public void PushStartBtn(){
        Login();
    }

    public void Login()
    {
        // 제공되는 함수 : 이메일과 비밀번호로 로그인 시켜 줌
        auth.SignInWithEmailAndPasswordAsync(emailField.text, pwField.text).ContinueWith(
            task => {
                if (task.IsCompleted && !task.IsFaulted && !task.IsCanceled)
                {
                    SceneManager.LoadScene("MainScene");
                    Debug.Log(emailField.text + " 로 로그인 하셨습니다.");
                }
                else
                {
                    Debug.Log("로그인에 실패하셨습니다.");
                }
            }
        );
    }
}
