using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAi : MonoBehaviour
{
 public NavMeshAgent Player;
 public GameObject OpTarget;
 public Game_Over Over;
private void Update()
{
    AI_Movement(); 
}





 private void AI_Movement()
 {
  Player.SetDestination(OpTarget.transform.position);
  if (Over.Att_W || Over.Att_W|| Over.tie)
        {
            Player.isStopped = true;
        }
 }
}
