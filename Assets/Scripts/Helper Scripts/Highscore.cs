using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Highscore : MonoBehaviour
{

    Text highscore;
    int scoreInt;
    // Start is called before the first frame update
    void Start()
    {
        highscore = GameObject.Find("Highscore").GetComponent<Text>();
        scoreInt = PlayerPrefs.GetInt("Highscore");
        highscore.text = scoreInt + "";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
