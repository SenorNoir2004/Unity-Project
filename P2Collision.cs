using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Collision : MonoBehaviour
{
    public LayerMask layerMask;
    public GameObject Attacker; 
    public bool Attacker_in_range = false;
    public int KnockBackForce = 50;
    public PlayerHealth AtHeath;
    public bool Att_Hit = false; 
    void FixedUpdate ()
    {
        
    }



    private void OnCollisionStay(Collision other)
    {
      

        if (layerMask == (layerMask | (1 << other.transform.gameObject.layer)))
        {
            if (other != null)
            {
              
                Attacker_in_range = true;
            }
            if (Attacker_in_range)
            {
                Rigidbody rb = other.collider.GetComponent<Rigidbody>();
               
                if (rb.tag == "Player")
                {
                    

                    if (rb != null)
                    {
                        Vector3 KnockBackDirection = other.transform.position - transform.position;
                        rb.AddForce(KnockBackDirection.normalized * KnockBackForce, ForceMode.Force);
                        AtHeath.Attacker_Current_Health -= 5f;
                        Att_Hit = true;

                    }
                }
            }

        }
    }
    private void OnCollisionExit(Collision other)
    {
        Attacker_in_range = false;
        Att_Hit = false;
    }
   
}

    
