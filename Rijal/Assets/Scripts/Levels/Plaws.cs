using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
public class Plaws : MonoBehaviour
{
    [SerializeField] private GameObject[] plaws;
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
        foreach(GameObject plaw in plaws)
        {
            if(plaw.GetComponent<XRSocketInteractor>().hasSelection == false)
            {
                isPlaying = false;
                return false;
            }
        }
        GameManager.Instance.zolailDone = true;
        return true;
        
    }
}
