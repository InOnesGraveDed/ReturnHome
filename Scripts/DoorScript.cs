using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DoorScript : MonoBehaviour
{
    public string targetSceneName;
    public Animator animator;

    public float dimDuration = 2f;
    public CanvasGroup dimPanel;

    void Awake()
    {
        animator = GameObject.Find("dimPanel").GetComponent<Animator>();
    }

    public void ExitAlimentara()
    {
        StartCoroutine(DimScreen(true));
    }

    private IEnumerator DimScreen(bool dimIn)
    {
        animator.SetTrigger("Trigger");
        yield return new WaitForSeconds(dimDuration);
        SceneManager.LoadScene(targetSceneName);
    }

}
