using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SwordStands : MonoBehaviour
{
    [SerializeField] private GameObject[] stands;
    [SerializeField] private AudioClip fullStory;
    private bool isPlaying = false;
    // Update is called once per frame
    void Update()
    {
        if(IsSwordStandsActive() && !isPlaying)
        {
            
            isPlaying = true;
            SoundManager.Instance.PlaySFX(fullStory);
        }
    }
    private bool IsSwordStandsActive()
    {
        foreach(GameObject stand in stands)
        {
            if(stand.GetComponent<XRSocketInteractor>().hasSelection == false)
            {
                isPlaying = false;
                return false;
            }
        }

        return true;
    }
}
