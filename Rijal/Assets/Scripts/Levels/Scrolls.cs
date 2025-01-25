using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
public class Scrolls : MonoBehaviour
{
    [SerializeField] private GameObject[] scrolls;
    [SerializeField] private AudioClip fullStory;
    private bool isPlaying = false;
    // Update is called once per frame
    void Update()
    {
        if(IsScrollsActive() && !isPlaying)
        {
            isPlaying = true;
            SoundManager.Instance.PlaySFX(fullStory);
        }
    }
    private bool IsScrollsActive()
    {
        foreach(GameObject scroll in scrolls)
        {
            if(scroll.GetComponent<XRSocketInteractor>().hasSelection == false)
            {
                isPlaying = false;
                return false;
            }
        }
        GameManager.Instance.libraryDone = true;
        return true;
        
    }
}
