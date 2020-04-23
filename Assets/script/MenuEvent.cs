using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEvent : MonoBehaviour
{
     

    void Start()
    {

    }
    void Update()
    {

    }
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

}