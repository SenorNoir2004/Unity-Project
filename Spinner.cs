using UnityEngine;

public class Spinner : MonoBehaviour
{
    public Quaternion startQuaternion; 
    public Vector3 QuaternionToVector;
    public Vector3 QuaternionReverse;
    public float lerpTime = 1;
    public bool Rotate = true;
    public bool RotateConstantly = true;
    public float rotateamount = 1;
    public Rigidbody rb; 
     
    
     


    // Start is called before the first frame update
    void Start()
    {
        
        startQuaternion = transform.rotation;
        QuaternionToVector = startQuaternion.eulerAngles; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if (Rotate)
        {
          
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(QuaternionReverse), Time.deltaTime * lerpTime);
        }


        if (RotateConstantly && !Rotate)
        {
           
            Vector3 nb = new Vector3(0f, 0f, 20f) * Time.deltaTime;
            transform.Rotate(nb);

        }
    }

    public void snapRotation(){
        transform.rotation = startQuaternion;
    }
}
