using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header(">>AUDIO SOURCES<<")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header(">>AUDIO CLIPS<<")]
    public AudioClip background;


    public static AudioManager instance;
    private void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    private void Start(){
        musicSource.clip = background;
        musicSource.Play();
    }
}
