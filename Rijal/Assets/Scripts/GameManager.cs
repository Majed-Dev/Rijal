using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singelton Pattern
    public static GameManager Instance {get; private set;}
    void Awake()
    {
        DontDestroyOnLoad(this);
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public bool zolailDone = false;
    public bool jazarDone = false;
    public bool sarraDone = false;
    public bool libraryDone = false;
}
