using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberTrigger : MonoBehaviour {

    public int score;

    // Script to add or subtract to total depending on which numbers are entered into or removed from the trigger zone.
    void OnTriggerEnter2D(Collider2D other)
    {
        // If number one has entered the pen
        if(other.name == "001(Clone)")
        {
            score = score + 1;
        }
        // If number 2 has entered the pen
        if (other.name == "002(Clone)")
        {
            score = score + 2;
        }
        // If number 3 has entered the pen
        if (other.name == "003(Clone)")
        {
            score = score + 3;
        }
        // If number 4 has entered the pen
        if (other.name == "004(Clone)")
        {
            score = score + 4;
        }
        // If number 5 has entered the pen
        if (other.name == "005(Clone)")
        {
            score = score + 5;
        }
        // If number 6 has entered the pen
        if (other.name == "006(Clone)")
        {
            score = score + 6;
        }
        // If number 7 has entered the pen
        if (other.name == "007(Clone)")
        {
            score = score + 7;
        }
        // If number 8 has entered the pen
        if (other.name == "008(Clone)")
        {
            score = score + 8;
        }
        // If number 9 has entered the pen
        if (other.name == "009(Clone)")
        {
            score = score + 9;
        }
        // If number 10 has entered the pen
        if (other.name == "010(Clone)")
        {
            score = score + 10;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // If number one has exited the pen
        if (other.name == "001(Clone)")
        {
            score = score - 1;
        }
        // If number 2 has exited the pen
        if (other.name == "002(Clone)")
        {
            score = score - 2;
        }
        // If number 3 has exited the pen
        if (other.name == "003(Clone)")
        {
            score = score - 3;
        }
        // If number 4 has exited the pen
        if (other.name == "004(Clone)")
        {
            score = score - 4;
        }
        // If number 5 has exited the pen
        if (other.name == "005(Clone)")
        {
            score = score - 5;
        }
        // If number 6 has exited the pen
        if (other.name == "006(Clone)")
        {
            score = score - 6;
        }
        // If number 7 has exited the pen
        if (other.name == "007(Clone)")
        {
            score = score - 7;
        }
        // If number 8 has exited the pen
        if (other.name == "008(Clone)")
        {
            score = score - 8;
        }
        // If number 9 has exited the pen
        if (other.name == "009(Clone)")
        {
            score = score - 9;
        }
        // If number 10 has exited the pen
        if (other.name == "010(Clone)")
        {
            score = score - 10;
        }
    }
}
