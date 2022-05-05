using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Linq;

public class P1_Skills : MonoBehaviour
{
    //SerializeField like public, but more protected 
     
    private float BoostDur = 0.7f;
    private float BoostMult = 10.3f;
    private Vector3 Boost_Distance;
    public MouseClickDetected Dclick;
    public GameObject P1;
    public GameObject Directional_ob;
    public MouseTracker MoInp;
    float startTime;
    public int Radius;
    private bool CoRoutineAllowed;
    // These Variables are specialised for Attacker skills
    public GameObject Bomb;
   public GameObject Bombclone;
    public GameObject Mega_Bomb;
   public  GameObject Mega_Bombcone;
    public GameObject Mouse;
    public int Bombcount = 4;
    public int MBombcount = 1;
    public Score T; 



    // Start is called before the first frame update
    private void Start()
    {

        CoRoutineAllowed = true;

    }
    //public Transform mouseTracker;

    // Update is called once per frame
    void Update()
    {
        if (Dclick.clickCounter > 0)
        {
            startTime = Time.time;
            StartCoroutine(P1_Boost());
        }
        if ((Bombcount > 0)  && (Input.GetMouseButtonDown(1)))
        {

            Bombcount -= 1;
            SpawnBombAtPosition_A1(Mouse.transform.position); 
            
        }
        //To differ from MBomg script 
        if ((MBombcount > 0) && Input.GetKeyDown("space"))
        {
            MBombcount -= 1;
            SpawnMBombAtPosition_A1(Mouse.transform.position);

        }

    }
    //Bomb spawning 
    private void SpawnBombAtPosition_A1 (Vector3 Spawnlocation)
    {
       Bombclone = Instantiate(Bomb, Spawnlocation, Quaternion.identity) as GameObject;
        Destroy(Bombclone, 2.4f);
    }
    private void SpawnMBombAtPosition_A1(Vector3 Spawnlocation)
    {
       Mega_Bombcone = Instantiate(Mega_Bomb, Spawnlocation, Quaternion.identity) as GameObject;
       Destroy(Mega_Bombcone, 7.8f);
    }

    //When the player presses the mouse button, the player accelersted to a location. This is boosting.
    IEnumerator P1_Boost()
    {
        CoRoutineAllowed = false;
        Rigidbody rb = P1.GetComponent<Rigidbody>();
        Collider[] collider = Physics.OverlapSphere(transform.position, Radius);

        while (Time.time < startTime + BoostDur)

        {
            if (Dclick.DoubleClick)
            {
                Boost_Distance = Directional_ob.transform.position - P1.transform.position;
                Boost_Distance.z = 0;
                rb.AddForce((Boost_Distance.normalized) * BoostMult, ForceMode.Acceleration);
                Debug.Log("Boost");

                foreach (Collider nearObject in collider)
                {
                  Rigidbody RB = nearObject.GetComponent<Rigidbody>();

                    if(RB.tag == "Player2")
                    {
                        T.P1_Score += 10f;
                    }

                }


            }
            rb.AddForce((Boost_Distance.normalized) / BoostMult, ForceMode.Acceleration);
            yield return new WaitForEndOfFrame();
        }
      
    }
}

   
          
        
    


      
 
    

