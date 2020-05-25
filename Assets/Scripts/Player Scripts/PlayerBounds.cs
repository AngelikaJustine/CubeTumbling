﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{

    public float min_X = -2.6f, max_X = 2.6f, min_Y = -5.6f;
    private bool out_Of_Bounds;

    public Score Score;

    void Start()
    {
        Score = GameObject.FindObjectOfType(typeof(Score)) as Score;
    }

    void Update()
    {
        CheckBounds();
    }

    void CheckBounds()
    {

        Vector2 temp = transform.position;

        if (temp.x > max_X)
            temp.x = max_X;

        if (temp.x < min_X)
            temp.x = min_X;

        transform.position = temp;

        if (temp.y <= min_Y)
        {

            if (!out_Of_Bounds)
            {

                out_Of_Bounds = true;

                SoundManager.instance.DeathSound();
                //  GameManager.instance.RestartGame();
                // Application.LoadLevel("GameOver");
                StartCoroutine(WaitForSceneLoad());
            }

        }

    } // check bounds

    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "TopSpike")
        {

            transform.position = new Vector2(1000f, 1000f);
            SoundManager.instance.DeathSound();
            //  GameManager.instance.RestartGame();
            StartCoroutine(WaitForSceneLoad());
        }

    }

    private IEnumerator WaitForSceneLoad()
    {
        Score.gameOver();
        yield return new WaitForSeconds(1);
        Application.LoadLevel("GameOver");
    }

} // class




































