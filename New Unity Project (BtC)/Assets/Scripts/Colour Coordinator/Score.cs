using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score;
    private int total;
	// Use this for initialization
	void Start ()
    {
        total = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        total = GameObject.Find("BlueTrigger").GetComponent<Ball_Detection>().player_score + GameObject.Find("RedTrigger").GetComponent<Ball_Detection>().player_score
              + GameObject.Find("GreenTrigger").GetComponent<Ball_Detection>().player_score + GameObject.Find("YellowTrigger").GetComponent<Ball_Detection>().player_score;
        string score_ = total.ToString();
        score.text = "SCORE : " + score_;

    }
}
