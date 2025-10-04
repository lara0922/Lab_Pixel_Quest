using UnityEngine;
using UnityEngine.Rendering;

public class HW2PlayerDie : MonoBehaviour
{
    public GameObject endPanel; 
    private string Enemy = "Enemy"; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Enemy)  
        {
            endPanel.SetActive(false); 
            gameObject.SetActive(false);
        }
    }
}
