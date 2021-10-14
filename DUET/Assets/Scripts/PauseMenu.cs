﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public  GameObject  pauseMenuUI;
    public void PauseMenuPanel()
    {
        if(isGamePaused)
        {
            Resume();
        }else
        {
            Pause();
        }
    }
    void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    // Update is called once per frame
    void Update()
    {
           
    }
}
