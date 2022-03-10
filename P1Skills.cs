using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class P1Skills : MonoBehaviour
{
    private float BoostDur = 0.7f;
    private float BoostMult = 1.5f; 
    NavMeshAgent PlayerMesh; 
    public MouseClickDetected Dclick;
    Vector3 MousePosVector;
    MouseTracker MoInp; 
    float startTime;  
    
     
    // Start is called before the first frame update
    void Start()
    {
    
    
    MoInp = GetComponent<MouseTracker>();
    PlayerMesh = GetComponent<NavMeshAgent>();

    }
     public Transform mouseTracker;

    // Update is called once per frame
    void Update()
    {
    startTime = Time.time;
     if(Dclick.DoubleClick == true){ 
      while (Time.time < startTime + BoostDur){
        PlayerMesh.destination = mouseTracker.position;
        PlayerMesh.speed = PlayerMesh.speed * BoostMult;
        Debug.Log("Boost");  
       

    
      PlayerMesh.speed = PlayerMesh.speed / BoostMult ; 
     
         
      }  
    }


      
 
     }
}
