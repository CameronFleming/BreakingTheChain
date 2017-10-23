using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_drag_2D : MonoBehaviour {

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 24.44f);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Debug.Log("drag");
        transform.position = objPosition;
    }
}
