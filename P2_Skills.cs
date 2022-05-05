using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class P2_Skills : MonoBehaviour
{
     NavMeshAgent PlayerMesh; 
    private float Boost_time;  
    private float BoostDur = 0.5f;
    private float BoostMult = 1.5f; 
    float startTime;
    private bool coRoutineAllowed;
    public P2Collision Hit; 
    public bool P2_Boost;
    public int boost_radius = 7;
    public GameObject P2;
    public GameObject Directional_ob;
    public Vector3 Boost_Distance; 



    // Start is called before the first frame update
    private void Start()
    {
    
    PlayerMesh = GetComponent<NavMeshAgent>();
    coRoutineAllowed = true; 
   
    }
     //public Transform mouseTracker;

    // Update is called once per frame
    void FixedUpdate()
    {
        Collider[] collider = Physics.OverlapSphere(transform.position, boost_radius);
        foreach (Collider Near in collider)
        {
            if (Near != null)
            {
                Boost_time = Time.time;
                Attack_Boost();
            }
           
        }

    }

    IEnumerator Attack_Boost ()
    {
        
            Rigidbody rb = P2.GetComponent<Rigidbody>();
            while (Time.time < Boost_time + BoostDur)
            {
                Boost_Distance = Directional_ob.transform.position - P2.transform.position;
                Boost_Distance.z = 0;
                rb.AddForce((Boost_Distance.normalized) * BoostMult, ForceMode.Acceleration);
                Debug.Log("Boost");

            }
        yield return new WaitForEndOfFrame();






    }
    
}
