using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLoadScene : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public bool canLeave = false;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && canLeave)
        {
            print("Load Scene !!!");
            SceneManager.LoadScene(sceneName); 
        }
    }
}
