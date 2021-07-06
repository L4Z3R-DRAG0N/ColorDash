using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 gravity;
    public float jump_power;
    public float move_speed;

    private Vector3 velocity;
    private Vector3 external_velocity;

    private Vector3 start_pos;

    private Rigidbody rig;
    private CharacterController controller;

    // init variables
    private void init()
    {
        velocity = new Vector3(0, 0, move_speed);

        rig = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position;
        init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            init();
            transform.position = start_pos;
        }
    }

    private void FixedUpdate()
    {

        // gravtiy
        if (!controller.isGrounded)
        {
            velocity += gravity;
        }

        // player input
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float jump = 0;
        if (controller.isGrounded)
        {
            jump = Input.GetAxisRaw("Jump");
        }

        velocity += new Vector3(0, jump * jump_power, 0);

        // constant moving forward
        // velocity += new Vector3(0, 0, move_speed);

        // external velocity from function blocks
        velocity += external_velocity;
        external_velocity = Vector3.zero;

        // move controller
        controller.Move(velocity * Time.fixedDeltaTime);
    }

    private void OnTriggerStay(Collider other)
    {
        switch (other.name)
        {
            case "Jump":
                external_velocity += new Vector3(0, 2, 0);
                return;

            case "Boost":
                external_velocity += new Vector3(0, 0, 3);
                return;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.name)
        {
            case "Boost":
                velocity = new Vector3(0, 0, move_speed);
                return;
        }
    }

}
