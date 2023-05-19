using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToAnswer = 30f;
    [SerializeField] float timeToCheckAnswer = 10f;

    float timerValue;
    public bool loadNextQuestion;
    public float fillFraction;
    public bool IsAnswering = false;

    void Update()
    {
        
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(IsAnswering)
        {
            if (timerValue > 0)
            {
                  fillFraction = timerValue/timeToAnswer;              
            }
            else
            {
                IsAnswering = false;
                timerValue = timeToCheckAnswer;
            }
        }        
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue/timeToCheckAnswer;
            }
            else
            {
                IsAnswering = true;
                timerValue = timeToAnswer;
            }            
        }
    }
}
