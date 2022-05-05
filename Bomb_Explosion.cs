using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Explosion : MonoBehaviour
{
    [SerializeField] private string HitTag = "Player";
    public PlayerHealth At_H;
    public Defender_Health Di_H;
    private float delay = 2;
    float countdown;
    private bool Exploded = false;
    public GameObject ExploationEffect;
    public GameObject ExploationEffect2;
    public GameObject ExploationEffectCl;
    public GameObject ExploationEffect2Cl;
    public float Blast_Radius = 9f;
    public float force = 900f;
    public GameObject Bomb;
    private bool startTime;
    public P1_Skills v;
    public Score T;
    public Nexus_Health Nex; 


    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonUp(1) || Input.GetMouseButton(1))
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
            if(Exploded)
            {
                Boom();
            }
                Destroy(ExploationEffectCl, 4);
            Destroy(ExploationEffect2Cl, 4);
            ExploationEffectCl = ExploationEffect;
            ExploationEffect2Cl = ExploationEffect2; 



        }
    }

    void Explode()
    {

        //Spawns in particle affect 
        Exploded = true;
        

        //Get nearby objects 
        //|Allows me to define a sphere collider at a given presision with a chosen radus. 
        Collider[] collider = Physics.OverlapSphere(transform.position, Blast_Radius);
        //Searching for rigid body on each object in list  
        foreach (Collider nearObject in collider)
        {
            Rigidbody rb = nearObject.GetComponent<Rigidbody>();
            //If yesa. add force pointing away froam granade.
            if (rb != null) ;
            {

                rb.AddExplosionForce(force, transform.position, Blast_Radius);
                
                if (rb.tag == "Player2")
                {
                    Debug.Log("This works");
                    Vector3 push = transform.position - rb.transform.position;
                    push = push.normalized * force;
                    rb.AddForce(push, ForceMode.Force);
                    Di_H.Defender_Current_Health -= 45f;
                    T.P1_Score += 30f;
                }
                if (rb.tag == "Nexus")
                {
                    Nex.Nexus_Current_Health -= 12;
                    T.P1_Score += 10f;
                }

            }
        }
       

      

    }
    void Boom ()
        {
        ExploationEffectCl = Instantiate(ExploationEffect, transform.position, transform.rotation);
        ExploationEffect2Cl = Instantiate(ExploationEffect2, transform.position, transform.rotation);

         }
  
}
