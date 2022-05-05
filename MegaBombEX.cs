using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaBomb: MonoBehaviour
{
    [SerializeField] private string HitTag = "Player";
    public float delay = 10f;
    float countdown;
    private bool Exploded = false;
    public GameObject ExploationEffect;
    public GameObject ExploationEffect2;
    public float SuckRadus = 20;
    public float Blast_Radius = 30f;
    public float force = 800f;
    public float SuckForce = 1.5f;
    public float SuckTime;
    public GameObject Bomb;
    private bool startTime;
    private float TimeClicked;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
        SuckTime = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            startTime = true;
        }
        if (startTime)
        {
            countdown -= Time.deltaTime;

        }


        //Calculates the remaining time since end of previous frame
        //Countdown each second 
        if (countdown <= 0f && !Exploded)
        {

            Explode();


        }
    }

    void Explode()
    {
        //Get nearby objects 
        //|Allows me to define a sphere collider at a given presision with a chosen radus. 
        Collider[] collider = Physics.OverlapSphere(transform.position, SuckRadus);
        //Searching for rigid body on each object in list  
        foreach (Collider nearObject in collider)
        {
            Rigidbody rb = nearObject.GetComponent<Rigidbody>();
            // Mega bomb calls suck function
            TimeClicked = Time.deltaTime;
            SuckTime -= Time.deltaTime;

            while (SuckTime != 0.0)
            {
                Vector3 PullForce = transform.position - rb.transform.position;
                PullForce = PullForce.normalized * SuckForce;
                if (rb != null)
                {
                    rb.AddForce(PullForce, ForceMode.Force);
                }
            }
            //If yesa. add force pointing away froam granade.
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, Blast_Radius);
                Exploded = true;
            }


        }
        Instantiate(ExploationEffect, transform.position, transform.rotation);
        Instantiate(ExploationEffect2, transform.position, transform.rotation);
        if (Exploded)
        {
            Destroy(Bomb);
        }


    }

    
}
