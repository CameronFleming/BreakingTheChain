using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberTarget : MonoBehaviour {

    public Text message;
    public int Target;
    public bool Correct;

	// Use this for initialization
	void Start () {
        
        Target = Random.Range(1, 50);
        string number = Target.ToString();
        message.text = "TARGET : " + number;
	}
	
	// Update is called once per frame
	void Update () {

		if(gameObject.GetComponent<NumberTrigger>().score == Target)
        {
            // Set target text to green, denoting the answer is correct.
            message.color = Color.green;
            Debug.Log("Correct answer!");
            // Add to the player's score.
            Correct = true;
            Invoke("NewTarget", 1);
        }
        else
        {
            message.color = Color.white;
            Correct = false;
        }
        
    }

    void NewTarget()
    {
        Target = Random.Range(1, 50);
        string number = Target.ToString();
        message.text = "TARGET : " + number;
    }
}
