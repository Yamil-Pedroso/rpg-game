using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed;
    public float jumpForce;
    public float xInput;
    void Start()
    {
        //rb.linearVelocity = new Vector2(0, 10); 
    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal"); 
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            //Debug.Log("Jump!");
        }
    }
}
