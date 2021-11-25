using UnityEngine;

public class Camera_Follow : MonoBehaviour

{
 // The target object 
 public Transform targetObject; 

 //Defult distance between the target and the player. 
 public Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update inqrequently
    void LateUpdate()
    {
      Vector3 newPosition = targetObject.transform.position + cameraOffset;
      transform.position = newPosition;  
    }
}
