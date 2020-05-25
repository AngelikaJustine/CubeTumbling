using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScore : MonoBehaviour
{
    Text score;
    int scoreInt;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
        scoreInt = PlayerPrefs.GetInt("Score");
        score.text = scoreInt + "";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
