using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private float xInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
