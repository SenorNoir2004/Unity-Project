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
    public MouseTracker MoInp; 
    float startTime;  
     
    
     
    // Start is called before the first frame update
    private void Start()
    {
    
    PlayerMesh = GetComponent<NavMeshAgent>();
    //Debug.Log(Dclick.DoubleClick);
   
    }
     //public Transform mouseTracker;

    // Update is called once per frame
    void Update()
    {
     //Debug.Log(MoInp.MousePosition3d);
     startTime = Time.time;
     if ( Dclick.DoubleClick){
      PlayerMesh.destination =  MoInp.MousePosition3d;
      PlayerMesh.speed = PlayerMesh.speed * BoostMult;
      Debug.Log("Boost");  
      PlayerMesh.speed = PlayerMesh.speed / BoostMult ; 
       
      }
    
     
    }

   
          
      }  
    


      
 
    

