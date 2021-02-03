using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float leftarrowmovment = 1.7F;
    public float rightarrowmovment = 3.4f;

       void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))

            rb.MovePosition(rb.position + Vector2.right* leftarrowmovment);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.right *rightarrowmovment);
    }

}
