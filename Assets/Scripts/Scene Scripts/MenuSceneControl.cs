using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void changeMenuScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
