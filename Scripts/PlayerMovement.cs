using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController character_controller;

    public float speed = 12f;
    public float gravity = -9f;
    public float jump_force = 3f;

    public Transform ground_check;
    public float ground_distance = 0.4f;
    public LayerMask ground_mask;


    Vector3 velocity;
    bool is_grounded;

    void Update()
    {
        is_grounded = Physics.CheckSphere(ground_check.position, ground_distance, ground_mask);

        if (is_grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float axis_x = Input.GetAxis("Horizontal");
        float axis_z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * axis_x + transform.forward * axis_z;

        character_controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && is_grounded)
        {
            velocity.y = Mathf.Sqrt(jump_force * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        character_controller.Move(velocity * Time.deltaTime);
    }
}
