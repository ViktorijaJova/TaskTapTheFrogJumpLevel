using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You Lost");
        Score.CurrentScore -= 10;
        // collision.gameObject.transform.position = transform.position;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



 


}
