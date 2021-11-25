using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Image healthBar;
    public float healthAmount = 100f;

    private void Update()
    {
        if(healthAmount <= 0) {
         Application.LoadLevel(Application.loadedLevel);
        }
        if(Input.GetKeyDown("E")){
            TakeDamage(20);
        }
        if(Input.GetKeyDown("T")){
            Healing(10);
        }
    }

    public void TakeDamage(float Damage)
    {
        healthAmount += Damage;
        healthBar.fillAmount = healthAmount / 100;

    }

    public void Healing(float healPoints)
    {
        healPoints += healPoints;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100;
    }
}