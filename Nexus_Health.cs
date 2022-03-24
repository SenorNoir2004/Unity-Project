using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nexus_Health : MonoBehaviour
{
 public float Nexus_Max_Health = 200;
 private bool once = false;

 private void Update(){
     if (Nexus_Max_Health < 200){
         if(once)
         {
           Debug.Log(Nexus_Max_Health);
           once = false; 
         }
         
     }
 }


}


