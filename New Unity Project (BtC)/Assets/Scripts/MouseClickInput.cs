using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickInput : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Numbers" || hitInfo.transform.gameObject.tag == "Player_Shirts")
                {
                    Debug.Log("It's working!");
                    Debug.Log("Hit number");
                    
                }
                else {
                    Debug.Log("nopz");
                }
            }
            else {
                Debug.Log("No hit");
            }
            Debug.Log("Mouse is down");
        }
    }
}