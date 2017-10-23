using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    // How far the camera is away in the z axis
    float distance = 7.0f;
    // Reference to the player game object
    public GameObject player;


	// Update is called once per frame
	void Update ()
    {
        // Where to position the camera in relation to the player object
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 4f, player.transform.position.z - distance);
	}
}
