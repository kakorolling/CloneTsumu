using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;

    public AudioSource bgmPlayer;
    public AudioSource sePlayer;
    public AudioClip[] seClips;
    
    void Awake()
    {
        instance = this;
    }
    
     public void PlaySESound(string type)
    {
        int index = 0;

        switch (type) {
            case "DecideBtn": index = 0; break;
        }

        sePlayer.clip = seClips[index];
        sePlayer.Play();
    }
}
