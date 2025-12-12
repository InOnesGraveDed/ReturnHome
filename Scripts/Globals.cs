using UnityEngine;

public class Globals : MonoBehaviour
{
    public static Transform spawnpoint;

    bool is_first_load = true;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        GlobalsCheck();
    }

    void GlobalsCheck()
    {
        if (is_first_load == true)
        {
            is_first_load = false;
            spawnpoint = GameObject.Find("MainSpawnpoint").GetComponent<Transform>();
        }
        else
        {
            spawnpoint = GameObject.Find("ShopExitPoint").GetComponent<Transform>();
        }
    }
}
