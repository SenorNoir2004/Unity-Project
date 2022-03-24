 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickDetected : MonoBehaviour{
    // firstClickTime Holds timestamp of the first click. timeBetweenClicks holds the time stam between clicks  
    private float firstClickTime;
    private float timeBetweenClicks = 0.5f;
    //Helps us not to start another core routine while one is running 
    public bool CorotineAllowed;
    public bool DoubleClick = false;
    public int clickCounter;
    

     void start(){
        firstClickTime = 0f;
        // Once first click is active, player has 0.2 secends to click again for double click to activate 
        clickCounter = 0;
        CorotineAllowed = true;
         


     }
     public void Update () {
        if(Input.GetMouseButtonUp(0))
            clickCounter += 1;
            
        
        // First time stap is taken, then amount of time is tracked 
        if ((clickCounter == 1) && (CorotineAllowed)){
            

            firstClickTime = Time.time + timeBetweenClicks;
            // A CoreRoutine is created here 
            StartCoroutine(DoubleClickDetection());

        }
     }
    
     // Research 
     IEnumerator DoubleClickDetection(){
        // A new core routine will not start unless this one is over 
        CorotineAllowed = false;
        //Only activates while time.time is less than firstClickTime (firstClickTime being greater than time.time for 1.2f)
        while (Time.time < (firstClickTime) ){
            if (clickCounter == 2){
                // Sends message to console 
                DoubleClick = true;
                
                
               
                
            }
            //Lasts untill the end of the frame 
            yield return new WaitForEndOfFrame();
        }
        //If routine was not run, the variables are resetted 
        

    
    
     clickCounter = 0;
     firstClickTime = 0f;
     CorotineAllowed = true; 
     DoubleClick = false; 
      
     
    }
 }

   