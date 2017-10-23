using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_movement : MonoBehaviour {

	void Update()
    {
        // If the object this is attached to (the ball)'s x pos is in the centre of the screen, change its y pos
        if(gameObject.transform.position.x == 0)
        {
            if (gameObject.transform.position.y > 1)
            {
                Vector3 position = gameObject.transform.position;
                position.y = position.y - 0.05f;
                gameObject.transform.position = position;
            }
            else if(gameObject.transform.position.y < 0)
            {
                Vector3 position = gameObject.transform.position;
                position.y = position.y + 0.05f;
                gameObject.transform.position = position;
            }
        }

        // If the object this is attached to (the ball)'s y pos is 1, change its x pos
        if(gameObject.transform.position.y == 1)
        {
            if(gameObject.transform.position.x > 0)
            {
                Vector3 position = gameObject.transform.position;
                position.x = position.x - 0.05f;
                gameObject.transform.position = position;
            }
            else if(gameObject.transform.position.x < 0)
            {
                Vector3 position = gameObject.transform.position;
                position.x = position.x + 0.05f;
                gameObject.transform.position = position;
            }

        } 
    }
}
