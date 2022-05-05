using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Nexus_Healthbar : MonoBehaviour
{
    public Nexus_Health NexHealth; 
    private Image HealthBar;
    private float fillamount;
   


    void Start()
    {
        //Find Image 
        HealthBar = GetComponent<Image>();


    }

   private void Update()
    {
        HealthBar.fillAmount = NexHealth.Nexus_Current_Health / NexHealth.Nexus_Max_Health;
    }
}
