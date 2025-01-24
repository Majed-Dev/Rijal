using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{

    //Singelton Pattern
    public static SoundManager Instance {get; private set;}
    void Awake()
    {
        DontDestroyOnLoad(this);
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    [Header("----Music Source----")]
    [SerializeField] AudioSource musicSource;
    [Header("----SFX Source----")]
    [SerializeField] AudioSource sfxSource;

    [Header("----Sound Track----")]
    public AudioClip soundTrack;


    void Start()
    {
        musicSource.clip = soundTrack;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
    public void StopSFX()
    {
        sfxSource.Stop();
    }
}
