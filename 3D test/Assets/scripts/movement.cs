using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [Header("setings")]
    public float speed;
    public float jumpForce;
    public float playerHeight;

    public KeyCode jumpKey = KeyCode.Space;
    public LayerMask whatIsGround;
    public Transform orientation;

    private bool grounded;


    float horizontalInput;
    float verticalInput;

    Vector3 vector3;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);

        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // when to jump
        if (Input.GetKey(jumpKey) && grounded)
            Jump();

    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        // calculate movement direction
        vector3 = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // on ground
        if (grounded)
            rb.AddForce(vector3.normalized * speed * 10f, ForceMode.Force);

        // in air
        else if (!grounded)
            rb.AddForce(vector3.normalized * speed * 10f, ForceMode.Force);
    }
    private void Jump()
    {
        // reset y velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
}
