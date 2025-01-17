using UnityEngine;

public class GrapableObject : MonoBehaviour
{
    [SerializeField] private AudioClip descriptionVoiceOver;
    bool isDescribed = false;

    public void Describe()
    {
        if(!isDescribed)
        {
            isDescribed = true;
            SoundManager.Instance.PlaySFX(descriptionVoiceOver); 
        }
        
    }
}
