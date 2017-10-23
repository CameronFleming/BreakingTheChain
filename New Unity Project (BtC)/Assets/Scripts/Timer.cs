using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    /*
    public Text timerText;
    public Text endTime;
    public Canvas endCanvas;
    private float startTime;
    private bool finished = false;

    // Use this for initialization
    public void TimerStart()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        GameObject Destroyed = GameObject.Find("Targets Destroyed");
        TargetsDestroyed tarDestroyed = Destroyed.GetComponent<TargetsDestroyed>();
        if (tarDestroyed.m_numDestroyed == 15)
        {
            finish();
            return;
        }

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
    public void finish()
    {
        if (finished != true)
        {
            // Write the player's time to the times text file
            System.IO.File.AppendAllText("F:/Target_Practice/times.txt", timerText.text);
        }
        finished = true;
        timerText.color = Color.red;
        endTime.text = timerText.text;
        endTime.color = Color.black;
        // Show endgame canvas
        endCanvas.gameObject.SetActive(true);
    }
    */
}

