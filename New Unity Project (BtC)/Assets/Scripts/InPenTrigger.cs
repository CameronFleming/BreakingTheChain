using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPenTrigger : MonoBehaviour {

	void OnTriggerStay(Collider other)
    {
        // When object is dragged into the trigger zone, stops random movement.
        other.GetComponent<AIRandomMovement>().InPen = true;
    }
    void OnTriggerExit(Collider other)
    {
        // When object is no longer in trigger zone, starts random movement.
        other.GetComponent<AIRandomMovement>().InPen = false;
    }
}
