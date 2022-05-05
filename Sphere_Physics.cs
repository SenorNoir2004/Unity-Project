using UnityEngine;

public class Sphere_Physics : MonoBehaviour
{
    
    public float Force;
   
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
         void OnCollisionEnter (Collision other)
        {
            Vector3 m_EulerAngleVelocity = new Vector3(20, 20, 20);
            Rigidbody Rb = GetComponent<Rigidbody>();
            if (Rb != null)
            {
                Vector3 X = Rb.position -  other.transform.position;
                Rb.AddForce(other.transform.position * Force);
                transform.position = X;
            }
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
            Rb.MoveRotation(Rb.rotation * deltaRotation);


        }
    }
}
