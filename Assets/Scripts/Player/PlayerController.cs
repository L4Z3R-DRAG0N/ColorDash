using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameSettings game_settings;
    public Vector3 gravity;
    public float jump_power;
    public float move_speed;
    public float move_speed_coefficient=1;

    public GameObject map;

    public Vector3 velocity;

    private Vector3 start_pos;

    private Rigidbody rig;
    private CharacterController controller;
    private TrailRenderer trail;

    // init variables
    public void Init()
    {
        trail.enabled = false;
        trail.Clear();

        velocity = new Vector3(0, 0, move_speed);
        transform.position = start_pos;

        trail.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position;

        rig = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        trail = GetComponentInChildren<TrailRenderer>();

        Init();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // move controller
        controller.Move((velocity) * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        // gravtiy
        if (!controller.isGrounded)
        {
            velocity += gravity;
        }

        // player input
        float jump = 0;
        if (controller.isGrounded)
        {
            velocity.y = 0;
            jump = Input.GetAxisRaw("Jump");
        }

        velocity += new Vector3(0, jump * jump_power, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Segment")
        {
            velocity += new Vector3(0, 0, 0.1f);
        }
    }
}
