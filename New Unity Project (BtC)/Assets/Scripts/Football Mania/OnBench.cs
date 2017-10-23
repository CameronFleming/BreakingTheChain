using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBench : MonoBehaviour
{
    // Trigger detection in 2D
	void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Numbers")
        {
            // When sprite is dragged into the trigger zone, stops random movement.
            other.GetComponent<Sprite_Movement>().onBench = true;
        }
        // Causes Unity to Crash
        /*
        // If the correct answer total has been made.
        if(GameObject.FindGameObjectWithTag("Trigger").GetComponent<NumberTarget>().Correct == true)
        {
            // While there are still numbers in the trigger zone
            while(GameObject.FindGameObjectWithTag("Trigger").GetComponent<TotalScore>().total > 0)
            {
                // Destroy the numbers.
                Destroy(other.gameObject);
                GameObject.Find("SpawnerManager").GetComponent<Spawner>().num_shirts--;
            }
        }*/
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Numbers")
        { 
        // When sprite is no longer in trigger zone, starts random movement.
        other.GetComponent<Sprite_Movement>().onBench = false;
        }
    }
}
