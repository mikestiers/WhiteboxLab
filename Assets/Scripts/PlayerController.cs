using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator), typeof(SpriteRenderer))]

public class PlayerController : MonoBehaviour
{
    // Components
    Rigidbody2D rb;

    // Movement variable
    public float speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");

        // Walking
        Vector2 moveDirection = new Vector2(hInput * speed, rb.velocity.y);
        rb.velocity = moveDirection;
    }
}
