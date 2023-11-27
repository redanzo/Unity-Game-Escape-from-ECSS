using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerCheckpoints : MonoBehaviour
{
    // CP = "checkpoint"
    public Transform cp1Transform;
    public Transform cp2Transform;
    public Transform cp3Transform;
    public int currentCP = 1;
    public bool player_failed;
    private Transform playerTransform;
    private NavMeshAgent agent;
    void Start()
    {
        player_failed = false;
        currentCP = 1;
        agent = gameObject.GetComponent<NPCPathfinding>().agent;
        playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        checkPlayerPosition();
        resetPlayer();
    }

    private void checkPlayerPosition(){
        if((playerTransform.position.x <= cp2Transform.position.x+1 && playerTransform.position.x >= cp2Transform.position.x-1) 
        && (playerTransform.position.z <= cp2Transform.position.z+1 && playerTransform.position.z >= cp2Transform.position.z-1) ){
            UnityEngine.Debug.Log("CP2 activated");  
            
            currentCP = 2;
        }
        else if((playerTransform.position.x <= cp3Transform.position.x+1 && playerTransform.position.x >= cp3Transform.position.x-1) 
        && (playerTransform.position.z <= cp3Transform.position.z+1 && playerTransform.position.z >= cp3Transform.position.z-1) ){
            UnityEngine.Debug.Log("CP3 activated");  

            currentCP = 3;
        }
    }

    private void resetPlayer(){
        if(player_failed)
        {
            switch (currentCP)
            {
                case 1:
                    playerTransform.transform.position = new Vector3(cp1Transform.position.x, cp1Transform.position.y, cp1Transform.position.z);
                    player_failed = false;
                    break;
                case 2:
                    playerTransform.transform.position = new Vector3(cp2Transform.position.x, cp2Transform.position.y, cp2Transform.position.z);
                    player_failed = false;
                    break;
                case 3:
                    playerTransform.transform.position = new Vector3(cp3Transform.position.x, cp3Transform.position.y, cp3Transform.position.z);
                    player_failed = false;
                    break;
            }
        }
    }
}
