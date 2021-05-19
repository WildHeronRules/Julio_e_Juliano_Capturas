using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunicaoInv : MonoBehaviour
{
    public int quantidade;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Colisao)
    {
        if (Colisao.gameObject.tag == "Pedra")
        {
            quantidade++;
        }
    }
}
