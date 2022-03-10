using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
      
    //Camera refrenece 
 [SerializeField] private Camera mainCamera;
 public Vector3 MousePosition3d; 
 //Returns ray towards the camera to the point the mouse is pointing at 
 public void Update(){
    Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
   //The ray is casted. Returns True if it hits something.
    if (Physics.Raycast(ray, out RaycastHit raycastHit)){
        transform.position = raycastHit.point; // raycastHit.point, stores the coordinates of the ray that was fired
        MousePosition3d = raycastHit.point;
    }
  
 
}
  
  }