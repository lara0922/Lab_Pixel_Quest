using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint; 
    public string nextLevel = "GeoLevel_2";
    private int coinCounter = 0;
    private int _health = 3;
    private int _maxHealth = 3;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Health":
                {
                    if (_health < _maxHealth)
                    {
                        _health++;
                        Destroy(collision.gameObject);
                    }
                    break; 
                }
            case "Coin": {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break; 
                }
            case "Death":
                {
                    {
                        _health--; 
                        if (_health <=0)
                        {
                            string thisLevel = SceneManager.GetActiveScene().name;
                            SceneManager.LoadScene(thisLevel);
                        }
                        else
                        {
                            transform.position = respawnPoint.position; 
                        }
                    }

                    break;
                }
            case "Respawn":
                {
                    respawnPoint.position = collision.transform.Find("Point").position;
                    break; 
                }
        }

    }
}
