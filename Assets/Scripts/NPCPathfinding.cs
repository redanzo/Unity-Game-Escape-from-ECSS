using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCPathfinding : MonoBehaviour
{
    public NavMeshAgent agent;

    void Update()
    {

        Transform playerTransform = gameObject.GetComponent<Transform>();
        // agent Temoc constantly tracks the player transform
        agent.SetDestination(playerTransform.position);
        
    }
}
