using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLoadScene : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(sceneToLoad == "Gameplay")
            {
                SceneManager.LoadScene(sceneToLoad);   
            }
            else if(sceneToLoad == "Library" && !GameManager.Instance.libraryDone)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else if(sceneToLoad == "SarraRoom" && !GameManager.Instance.sarraDone)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else if(sceneToLoad == "ZolailRoom" && !GameManager.Instance.zolailDone)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else if(sceneToLoad == "SwordRoom" && !GameManager.Instance.jazarDone)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
