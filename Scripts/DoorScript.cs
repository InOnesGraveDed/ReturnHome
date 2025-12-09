using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Transform door_transform;
    public Transform key;
    public bool is_key_picked = false;

    bool player_in_area = false;

    void Update()
    {
        is_key_picked = !key.gameObject.activeSelf;
        if (Input.GetKeyDown(KeyCode.F) && is_key_picked)
        {
            door_transform.position += new Vector3(0f, 100f, 0f);
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            player_in_area = true;
        }
    }

}
