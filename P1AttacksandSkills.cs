using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1AttacksandSkills : MonoBehaviour
{
 
 Movement moveScript;

  public float DashSpeed;
  public float DashTime;

  void start()
   {
      moveScript = GetComponent<Movement>();

   }

 void Update()
  {
      if (Input.GetKeyDown("a"))
      {
          StartCoroutine(Dash());
         
     
      }

   IEnumerator Dash()
    {
       float startTime = Time.time;

       while(Time.time < startTime + DashTime)
       {
         moveScript.controller.Move(moveScript.DirectT * moveScript.Player01_Movement.Player_velocity * Time.deltaTime);

           yield return null; 
       }
    }

  }
}
