using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You Lost");
        Score.CurrentScore -= 10;
        //rb.transform.position =  Vector2.down;
        
        // collision.gameObject.transform.position = transform.position;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



 


}
