using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker_C : MonoBehaviour
{
    public LayerMask layerMask;
    public bool Diff_Hit = false;
    public bool Diff_in_range = false;
    public Defender_Health DiffHealth;
    public GameObject Defender_;
    public int KnockBackForce;

    private void OnCollisionEnter (Collision other)
    {
        if (layerMask == (layerMask | (1 << other.transform.gameObject.layer)))
        {
            if (other != null)
            {

                Diff_in_range = true;
            }
            if (Diff_in_range)
            {
                if (Defender_.tag == "Player")
                {
                    Rigidbody rb = other.collider.GetComponent<Rigidbody>();

                    if (rb != null)
                    {
                        Vector3 KnockBackDirection = other.transform.position - transform.position;
                        rb.AddForce(KnockBackDirection.normalized * KnockBackForce, ForceMode.Force);
                        DiffHealth.Defender_Current_Health -= 15f;
                        Diff_Hit = true;
                      
                    }
                }
            }

        }
    }
    private void OnCollisionExit(Collision other)
    {
        Diff_in_range = false;
        Diff_Hit = false;
       
    }
}
