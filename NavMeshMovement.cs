using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent Player;
    public GameObject TargetDest;

    void Update(){
        //Takes Camera and screen and creates raycast 
        if(Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint; 

            if(Physics.Raycast(ray, out hitPoint)){
                TargetDest.transform.position = hitPoint.point;
                //Navigation will take this line of code, set destination, and plot apath over to the target destination 
                Player.SetDestination(hitPoint.point);
            }
        }
    }
}
