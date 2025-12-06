using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5; 
    private SpriteRenderer _spriteRenderer;  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y); 
        if (transform.GetChild(0).GetComponent<SpriteRenderer>())
        {
            _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>(); 
        }
        if (_spriteRenderer)
        {
            if (xInput >= 0) { _spriteRenderer.flipX = true; }
            else {  _spriteRenderer.flipX = false;}
        }
    }
}
