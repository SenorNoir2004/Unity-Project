using UnityEngine;

public class Spinner : MonoBehaviour
{
    public Quaternion startQuaternion; 
    public Vector3 QuaternionToVector;
    public Vector3 QuaternionReverse;
    public float lerpTime = 1;
    public bool Rotate;
    public bool RotateConstantly;
    public float rotateamount = 1;
    
     


    // Start is called before the first frame update
    void Start()
    {
        
        startQuaternion = transform.rotation;
        QuaternionToVector = startQuaternion.eulerAngles; 
    }

    // Update is called once per frame
    void Update(){
      if (Rotate)
         transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(QuaternionReverse), Time.deltaTime * lerpTime );  
         if(RotateConstantly && !Rotate)
             transform.Rotate( Vector3.back * rotateamount);
    }

    public void snapRotation(){
        transform.rotation = startQuaternion;
    }
}
