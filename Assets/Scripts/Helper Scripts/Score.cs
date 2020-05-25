﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour

{

    Text score;

    int scoreInt;
    int highscore;
    int frames;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
        scoreInt = 0;
        startTime = Time.time;
        highscore = PlayerPrefs.GetInt("Highscore");
        // highscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreInt = (int)(Time.time - startTime);
        Scoring();
    }

    void Scoring()
    {
        score.text = scoreInt + "";
        PlayerPrefs.SetInt("Score", scoreInt);

        if (scoreInt > highscore)
        {
            PlayerPrefs.SetInt("Highscore", scoreInt);
        }

    }
}
