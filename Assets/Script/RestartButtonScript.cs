﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void restartScene1() {
        SceneManager.LoadScene("Level1");
    }

    public void restartScene2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void restartScene3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void exitGame() {
        Application.Quit();
    }

}
