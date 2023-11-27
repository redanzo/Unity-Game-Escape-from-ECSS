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
        // add conditions to start pathfinding (player completes puzzle and walks over certain position)
        agent.SetDestination(playerTransform.position);
        
    }
}
