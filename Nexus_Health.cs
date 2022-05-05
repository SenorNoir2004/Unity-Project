using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Nexus_Health : MonoBehaviour
{
    public pHHealth Health;
    public float Nexus_Max_Health = 200;
    public float Nexus_Current_Health = 200f;

    void Start()
    {
        Health.SetMaxHealth(Nexus_Max_Health);
    }

    void FixedUpdate()
    {
        Health.SetHealth(Nexus_Current_Health);

    }
}


