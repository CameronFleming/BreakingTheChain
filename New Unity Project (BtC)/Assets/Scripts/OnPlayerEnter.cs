using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnPlayerEnter : MonoBehaviour {

    public Canvas messagebox;

    void OnTriggerStay(Collider other)
    {
        messagebox.gameObject.SetActive(true);

        // If player is within the trigger zone and they press the space button
        if(other.name == "Player" && Input.GetButton("Space"))
        {
            // Perform act
            Debug.Log("Player activates trigger");
        }
    }
    void OnTriggerExit(Collider other)
    {
        messagebox.gameObject.SetActive(false);
    }
}
