﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneControl : MonoBehaviour
{
    // int sceneIndex;

    // Start is called before the first frame update
    // void Start()
    // {
    //     sceneIndex = SceneManager.GetActiveScene().buildIndex;    
    // }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    // public void LoadNextLevel(){
    //     SceneManager.LoadScene(sceneIndex+1);
    // }

    public void changeMenuScene(string sceneName){
        Application.LoadLevel(sceneName);
    }
}
