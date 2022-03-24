using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseTracker : MonoBehaviour
{
  
public Vector3 MousePosition3d;
    //Camera refrenece 
 [SerializeField] private Camera mainCamera;
 [SerializeField] private LayerMask layerMask; 
   private float MaxRayDistance = 200f;
   
 
 //Returns ray towards the camera to the point the mouse is pointing at 
 public Vector3 Update(){
  
   Vector2 MousePosition = Input.mousePosition;
    Ray ray = mainCamera.ScreenPointToRay(MousePosition);
    //Debug.DrawRay(ray.origin, ray.direction * MaxRayDistance, Color.green);
   //The ray is casted. Returns True if it hits something. 
    if (Physics.Raycast(ray, out RaycastHit rayCastHit, MaxRayDistance)){
         transform.position = rayCastHit.point; // raycastHit.point, stores the coordinates of the ray that was fired
       

         }
        MousePosition3d = transform.position; 
  
    return MousePosition3d;
 

  

   }
   
   
   
 }
 
  
  
