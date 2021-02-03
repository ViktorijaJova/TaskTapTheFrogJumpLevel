using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starting : MonoBehaviour
{
    public Button start;
    void Start()
    {
        start.onClick.AddListener(() => Startings());
    }

   void Startings()
    {
        SceneManager.LoadScene("Main");
    }
}
