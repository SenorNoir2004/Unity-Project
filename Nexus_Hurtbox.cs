using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nexus_Hurtbox : MonoBehaviour
{
 public Nexus_Health NHealth; 
 //Nexus rigidbody 
 public Rigidbody Nex_Rig; 
 
 

private void Start(){
    NHealth = transform.GetComponentInParent<Nexus_Health>();
   // Nex_Rig = transform.GetComponentInParent<RigidBody>();
   

}

      
    
}
