using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        CheckPosition();
    }

    void CheckPosition()
    {
        if (this.transform.position.y < -1.5)
        {
            Vector3 position = this.transform.position;
            position.y = 0.9f;
            position.x = -0.024f;
            position.z = -2.359f;
            this.transform.position = position;

            Quaternion rotation = this.transform.rotation;
            rotation.x = 0;
            rotation.y = 0;
            rotation.z = 0;
            this.transform.rotation = rotation;
        }
    }
}

