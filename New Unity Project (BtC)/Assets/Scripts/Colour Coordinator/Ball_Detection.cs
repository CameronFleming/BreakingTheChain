using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Detection : MonoBehaviour {

    public int player_score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Checks if the object colliding is a blue ball and the zone its colliding with is also blue
        if(other.name.Contains("Blue") == true && gameObject.name.Contains("Blue") == true)
        {
            // Add to the player score
            player_score++;
        }
        // Checks if the object colliding is a yellow ball and the zone its colliding with is also yellow
        else if (other.name.Contains("Yellow") == true && gameObject.name.Contains("Yellow") == true)
        {

            // Add to the player score
            player_score++;
        }
        // Checks if the object colliding is a red ball and the zone its colliding with is also red
        else if (other.name.Contains("Red") == true && gameObject.name.Contains("Red") == true)
        {
         
            // Add to the player score
            player_score++;
        }
        // Checks if the object colliding is a green ball and the zone its colliding with is also Green
        else if (other.name.Contains("Green") == true && gameObject.name.Contains("Green") == true)
        {
            
            // Add to the player score
            player_score++;
        }
        // Destroy the object
        Destroy(other.gameObject);
        // Remove 1 from the number of balls spawned in the "Spawner" script attached to the object spawner
        GameObject.Find("SpawnerManager").GetComponent<Spawner>().num_objects--;
    }
}
