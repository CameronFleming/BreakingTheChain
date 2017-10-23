using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {

            if (Input.GetButton("W"))
            {
                Vector3 position = this.transform.position;
                position.x = position.x + 0.01f;
                position.z = position.z + 0.01f;
                this.transform.position = position;
            }
            if (Input.GetButtonDown("A") && !Input.GetButton("D"))
            {
                StartCoroutine(Rotate(Vector3.forward * 90, 0.05f));
                /*
                Vector3 position = this.transform.position;
                position.x = position.x - 0.01f;
                position.z = position.z + 0.01f;
                this.transform.position = position;
                */
            }
            if (Input.GetButton("S"))
            {
            
                Vector3 position = this.transform.position;
                position.x = position.x - 0.01f;
                position.z = position.z - 0.01f;
                this.transform.position = position;             
            }
            if (Input.GetButtonDown("D") && !Input.GetButton("A"))
            {
                StartCoroutine(Rotate(Vector3.forward * -90, 0.05f));
            /*
            Vector3 position = this.transform.position;
                position.x = position.x + 0.01f;
                position.z = position.z - 0.01f;
                this.transform.position = position;
                */
        }
    }

    IEnumerator Rotate(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        for(float t = 0f; t <= 1f; t += Time.deltaTime/inTime)
        {
            transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
        transform.rotation = toAngle;
    }

}