﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public static GameManger Instance;
    void Awake(){
        if(Instance == null){
            Instance =  this;
        }
    }
    public bool isGameOver = false;
}
