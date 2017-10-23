using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_Generator : MonoBehaviour {

    public int min;
    public int max;
    public int target;
    public Text message;
    public bool correct;

    void Start()
    {
        if (GameObject.Find("SpawnerManager").GetComponent<Spawner>().num_objects == 10)
        {
            
            // Min is equal to the smallest number randomly spawned
            // Max is equalt to the sum total of all numbers spawned
            target = Random.Range(min, max);
            string number = target.ToString();
            message.text = "TARGET : " + number;
        }
    }

	// Wait until all numbers have been spawned
    void Update()
    {
        if(GameObject.Find("SpawnerManager").GetComponent<Spawner>().num_objects == 10)
        {
            if(GameObject.FindGameObjectWithTag("Trigger").GetComponent<NumberTrigger>().score == target)
            {
                // Set target text to green, denoting the answer is correct.
                message.color = Color.green;
                correct = true;
                Invoke("NewTarget", 1);
            }
            else
            {
                message.color = Color.white;
                correct = false;
            }
            // pick a random number from the lowest to the sum total of all numbers spawned
        }
    }
    
    void NewTarget()
    {
        target = Random.Range(min, max);
        string number = target.ToString();
        message.text = "TARGET : " + number;
    }
}
