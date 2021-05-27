using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarPedra : MonoBehaviour
{

    public float speedX, speedY;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speedX, speedY);
    }

    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D xTag)
    {
        if(xTag.gameObject.tag == "Monstro")
        {
            Destroy(this.gameObject);
        }
    }
}
