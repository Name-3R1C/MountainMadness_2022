using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 300;
    public Text timeText;
    public bool timerRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerRunning)
        {
            if(timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
        }
        
        DisplayTime(timeValue);
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
