using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float Attacker_Max_Health = 120;
    public float Attacker_Current_Health = 120;
    public pHHealth AttHealthBar;

    void Start()
    {
        AttHealthBar.SetMaxHealth(Attacker_Max_Health);
    }

    void FixedUpdate()
    {
        AttHealthBar.SetHealth(Attacker_Current_Health);

    }


}
