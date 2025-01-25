using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
public class Necks : MonoBehaviour
{
    [SerializeField] private GameObject[] necks;
    [SerializeField] private AudioClip fullStory;
    private bool isPlaying = false;
    // Update is called once per frame
    void Update()
    {
        if(IsNeckStandActive() && !isPlaying)
        {
            
            isPlaying = true;
            SoundManager.Instance.PlaySFX(fullStory);
        }
    }
    private bool IsNeckStandActive()
    {
        foreach(GameObject neck in necks)
        {
            if(neck.GetComponent<XRSocketInteractor>().hasSelection == false)
            {
                isPlaying = false;
                return false;
            }
        }
        GameManager.Instance.sarraDone = true;
        return true;
        
    }
}
