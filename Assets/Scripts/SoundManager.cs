using UnityEngine;

public class SoundManager : MonoBehaviour
{
   
    public static SoundManager instace;

    public AudioSource sePlayer;
    public AudioSource bgmPlayer;

    public AudioClip[] seClips;
    
    void Awake(){
        instace = this;
    }

    public void PlaySE(string type){
        int index = 0;
        //se 추가
        switch(type){
            case "Enter": index = 0; break;
        }

        sePlayer.clip = seClips[index];
        sePlayer.Play();
    }
}
