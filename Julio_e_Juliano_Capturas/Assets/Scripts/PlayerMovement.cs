using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 1f;
    public Rigidbody2D rb;
    Vector2 move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        if(Input.GetKey("left shift"))
        {
            speed = 10f;
        }
        else
        {
            speed = 3f;
        }

        if(move.x != 0 && move.y != 0){
            speed = speed - 0.5f;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.deltaTime);

    }




}
