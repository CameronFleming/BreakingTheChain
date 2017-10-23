using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

    public Text totalText;
    public Canvas Canvas;
    public int total;

    // Use this for initialization
    void Start ()
    {
        total = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        total = gameObject.GetComponent<NumberTrigger>().score;
        string score = total.ToString();
        totalText.text = "TOTAL : " + score;
	}
}
