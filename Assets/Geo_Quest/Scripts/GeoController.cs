using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geo : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public int speed = 5;
    public string nextlevel = "Scene_2";

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }                                                                                                                                                                                                                  

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break; 
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break; 
                }
        }
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
               transform.position += newVector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
               transform.position += newVector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
               transform.position += newVector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
               transform.position += newVector3(-1, 0, 0);
        }
        */ 
    }
}
