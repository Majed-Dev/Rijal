using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SocketObject : MonoBehaviour
{
    public bool isActive = false;
    [SerializeField] private AudioClip feedback;
    public void Feedback()
    {
        SoundManager.Instance.PlaySFX(feedback);
    }
    public void ActiveEnable()
    {
        isActive = true;
        SoundManager.Instance.StopSFX();
    }
    public void ActiveDisable()
    {
        isActive = false;
    }
}
