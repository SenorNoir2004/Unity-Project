using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hurt : MonoBehaviour
{
    public P2Collision Attacked;
    public GameObject Hurn_Effect; 

    // Update is called once per frame
    void Update()
    {
      if (Attacked.Att_Hit)
        {
            Instantiate(Hurn_Effect, transform.position, transform.rotation);
        }
    }
}
