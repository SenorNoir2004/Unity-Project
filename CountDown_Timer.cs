using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDown_Timer : MonoBehaviour
{
    bool Timer_Acive = false; 
    public bool Timer_Finished = false; 
    public Text Current_Time_Text; 
    float Current_Time; 
    public int startMinutes; 
    

    void Start()
    {
        Current_Time = startMinutes * 60;
        Timer_Acive = true; 
        Timer_Finished = false;
    }

    void Update()
    {
      Current_Time_Text.text = Current_Time.ToString();

      if (Timer_Acive == true)
      {
          //Current Time decreases by the amount of miliseconds that have passed _ This method is done to avoid any timming issue 
          Current_Time = Current_Time - Time.deltaTime; 
          if (Current_Time <= 0)
          {
              //stop the time
             Timer_Acive = false;
              Start();
              Timer_Finished = true; 
              Debug.Log("Timer finished");
          }
      }
      //The variable will store the amount of time. Allows me to convert second into minuts, hour ect.
      TimeSpan time = TimeSpan.FromSeconds(Current_Time);
      Current_Time_Text.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

}
