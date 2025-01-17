using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Singelton Pattern
    public static SoundManager Instance {get; private set;}
    void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There is More Than One Sound Manager Instance");
        }
        Instance = this;
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
}
