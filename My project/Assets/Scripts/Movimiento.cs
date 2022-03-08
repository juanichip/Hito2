using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5;

    public Rigidbody2D rb;

    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h * speed, rb.velocity.y);
        float v = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            if (contador < 2)
            {
                rb.velocity = new Vector2(rb.velocity.x, v * speed);
            }

            contador++;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        contador = 0;
    }
}
