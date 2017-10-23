using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    public int player_score;

	void Update()
    {
        //If player gets answer right add to their score
        if(GameObject.FindGameObjectWithTag("Trigger").GetComponent<NumberTarget>().Correct == true)
        {
            player_score = player_score + 1;

        }
    }
}
