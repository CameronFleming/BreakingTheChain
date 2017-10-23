using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Movement : MonoBehaviour {

    public float velocity;
    public float XMax;
    public float YMax;
    public float XMin;
    public float YMin;

    public bool onBench;

    private float x;
    private float y;
    private float tiempo;

	// Use this for initialization
	void Start ()
    {
        onBench = false;
        x = Random.Range(-velocity, velocity);
        y = Random.Range(-velocity, velocity);

    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (onBench != true)
        {
            if (transform.localPosition.x > XMax)
            {
                x = Random.Range(-velocity, 0.0f);
                tiempo = 0.0f;
            }
            if (transform.localPosition.x < XMin)
            {
                x = Random.Range(0.0f, velocity);
                tiempo = 0.0f;
            }
            if (transform.localPosition.y > YMax)
            {
                y = Random.Range(-velocity, 0.0f);
                tiempo = 0.0f;
            }
            if (transform.localPosition.y < YMin)
            {
                y = Random.Range(0.0f, velocity);
                tiempo = 0.0f;
            }


            if (tiempo > 1.0f)
            {
                x = Random.Range(-velocity, velocity);
                y = Random.Range(-velocity, velocity);
                tiempo = 0.0f;
            }

            transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y + y, transform.localPosition.z);
        }
    }
}
