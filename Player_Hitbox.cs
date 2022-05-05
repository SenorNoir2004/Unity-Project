using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hitbox : MonoBehaviour
{
    public Defender_Health DHealth; 
    public GameObject Defender_;
    public float Basic_Damge = 20;
    public Nexus_Health NHealth;
    public MouseClickDetected DC; 
    public Nexus_Hurtbox NexH;
    public Selection_Manager Select;
    public float Nexus;
    public bool Nex_Hit;
    public int KnockBackForce = 30;
    public bool Deff_Hit;
    //

    //Can distinguish what I want/not want to check when the game is being run. Avoids waisting efficiency 
    public LayerMask layerMask;
     
    //Triggers can extend triggers outside render radius. This is made for fast moving objects, to help it trigger   
    public void OnCollisionEnter(Collision other)
    {
        
        //performs a big shift comparison between layer mask and the collider object 
        //Doent hit everything every frame 
        if (layerMask == (layerMask| (1 << other.transform.gameObject.layer)))
         {
           //GetComponet is an expensive call, dont want to call every frame 
           
         
         if ( (other.transform.gameObject.tag == "Nexus") & ( other != null)) 
          {
               
            NHealth.Nexus_Current_Health  -= Basic_Damge;
                Nex_Hit = true;
            
          }
            else
            {
                Nex_Hit = true;
            }
            Rigidbody rb = other.collider.GetComponent<Rigidbody>();
            if (rb.tag == "Player")
                {
                

                if (rb != null)
                {
                    Vector3 KnockBackDirection = other.transform.position - transform.position;
                    rb.AddForce(KnockBackDirection.normalized * KnockBackForce, ForceMode.Force);
                    DHealth.Defender_Current_Health -= 20f;
                    Deff_Hit = true;

                }
            }
        }
        

    }
    
}
