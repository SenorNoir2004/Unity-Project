using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ray_Track : MonoBehaviour
{
    public Camera cam;
    private Ray_Track ray;
    public GameObject Player;
   // public GameObject TargetDest;
    private bool Coroutine = false;
    //public GameObject Target;
    public Player_Hitbox P_Hit;
    private UnityEngine.AI.NavMeshAgent Nav_Player;
    public Selection_Manager nex_Selection;
    public MouseClickDetected Count_Mouse;

    private float x;

    void Start()
    {
        Nav_Player = GetComponent<UnityEngine.AI.NavMeshAgent>(); 
    }


    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))

        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;


            if (Physics.Raycast(ray, out hitPoint))
            {
                //Navigation will take this line of code, set destination, and plot apath over to the target destination 

               
                x = Time.time;
                while ((Time.time < x + 0.2f) && (P_Hit.Nex_Hit == false))
                {
                    Nav_Player.SetDestination(hitPoint.point);
                }
            }

            //Checks if nexus has been selected and transforms to the destination 
            if ((Count_Mouse.DoubleClick))
            {

                if (nex_Selection.Nex_Selected)
                {
                   // TargetDest.transform.position = nex_Selection.Nexus_Location;
                    x = Time.time;
                    while ((Time.time < x + 0.2f) && (P_Hit.Nex_Hit == false))
                    {
                        Nav_Player.SetDestination(nex_Selection.Nexus_Location);
                    }
                }


            }
        }

    }
}

