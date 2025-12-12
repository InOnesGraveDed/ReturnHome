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

    private IEnumerator DimScreen(bool dimIn)
    {
        animator.SetTrigger("Trigger");
        yield return new WaitForSeconds(dimDuration);
        SceneManager.LoadScene(targetSceneName);
    }
}
