using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    public float player_reach = 3f;
    Interactable current_interactable;

    void Update()
    {
        check_interaction();
        if (Input.GetKeyDown(KeyCode.F) && current_interactable != null)
        {
            current_interactable.Interact();
        }
    }

    void check_interaction()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(ray, out hit, player_reach))
        {
            if (hit.collider.tag == "Interactable")
            {
                Interactable new_interactable = hit.collider.GetComponent<Interactable>();

                if (new_interactable.enabled)
                {
                    set_new_current_interactable(new_interactable);
                }
                else
                {
                    disable_current_interactable();
                }
            }
            else
            {
                disable_current_interactable();
            }
        }
        else
        {
            disable_current_interactable();
        }
    }
    void set_new_current_interactable(Interactable new_interactable)
    {
        current_interactable = new_interactable;
        HUDController.instance.enable_interaction_text(current_interactable.message);
    }
    void disable_current_interactable()
    {
        HUDController.instance.disable_interaction_text();
        if (current_interactable)
        {
            current_interactable = null;
        }
    }
}
