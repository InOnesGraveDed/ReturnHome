using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{
    public static HUDController instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] TMP_Text interaction_text;

    public void enable_interaction_text(string text)
    {
        interaction_text.text = text;
        interaction_text.gameObject.SetActive(true);
    }
    public void disable_interaction_text()
    {
        interaction_text.gameObject.SetActive(false);
    }
}
