using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent on_interaction;

    public string message;

    public void Interact()
    {
        on_interaction.Invoke();
    }
}
