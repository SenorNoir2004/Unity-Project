using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hitbox : MonoBehaviour
{
    public float Basic_Damge = 30;
    public Vector3 NockBack = new Vector3(0,2,2);
    public Nexus_Health NHealth;
    public MouseClickDetected DC; 
    public Nexus_Hurtbox NexH;
    public Selection_Manager Select;
    public GameObject Attacker; 

    //Can distinguish what I want/not want to check when the game is being run. Avoids waisting efficiency 
    public LayerMask layerMask;
     
    //Triggers can extend triggers outside render radius. This is made for fast moving objects, to help it trigger   
    private void OnTriggerEnter(Collider other)
    {
        //performs a big shift comparison between layer mask and the collider object 
        //Doent hit everything every frame 
        if (layerMask == (layerMask| (1 << other.transform.gameObject.layer)))
         {
           //GetComponet is an expensive call, dont want to call every frame 
           NexH = other.GetComponent<Nexus_Hurtbox>();
           
         
         if ( (Select.Nex_Selected) & ( other)) 
          {
            NHealth.Nexus_Max_Health  -= Basic_Damge;
            Attacker.transform.position -= NockBack;
            
            
          } 
        }
        
     
    }
}
