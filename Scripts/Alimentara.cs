using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Alimentara : MonoBehaviour
{
    public string targetSceneName;
    public GameObject playerSpawn;
    public Animator animator;
    // public Globals globals;

    public float dimDuration = 2f;
    public CanvasGroup dimPanel;

    void Awake()
    {
        animator = GameObject.Find("dimPanel").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // StartCoroutine(TransitionScene());
            StartCoroutine(DimScreen(true));
            // SceneManager.LoadScene(targetSceneName);
        }
    }

    // private IEnumerator TransitionScene()
    // {
    // Dim screen
    // yield return StartCoroutine(DimScreen(true));

    // Store player position relative to this trigger
    // Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    // PlayerPrefs.SetFloat("PlayerX", playerPos.x + playerSpawnOffset.x);
    // PlayerPrefs.SetFloat("PlayerY", playerPos.y + playerSpawnOffset.y);
    // PlayerPrefs.SetFloat("PlayerZ", playerPos.z + playerSpawnOffset.z);
    // PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);

    // Load target scene
    //     SceneManager.LoadScene(targetSceneName);
    // }

    private IEnumerator DimScreen(bool dimIn)
    {
        animator.SetTrigger("Trigger");
        yield return new WaitForSeconds(dimDuration);
        SceneManager.LoadScene(targetSceneName);
    }
}
