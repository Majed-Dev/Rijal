using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SwordStands : MonoBehaviour
{
    [SerializeField] private GameObject[] stands;
    // Update is called once per frame
    void Update()
    {
        if(IsSwordStandsActive())
        {
            //Activate Story Ending
            print("3 Swords Found !!!!!!!!!!!");
        }
    }
    private bool IsSwordStandsActive()
    {
        foreach(GameObject stand in stands)
        {
            if(stand.GetComponent<XRSocketInteractor>().hasSelection == false)
            {
                return false;
            }
        }
        return true;
    }
}
