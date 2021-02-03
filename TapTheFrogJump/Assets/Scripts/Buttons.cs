using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button reset;
    private void Start()
    {
        reset.onClick.
            AddListener(() => Reset());
        

    }
    private void Reset()
    {
        SceneManager.LoadScene("Start");
    }
 
}
