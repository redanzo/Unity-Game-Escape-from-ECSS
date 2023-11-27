using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.AI;

public class TemocBehavior : MonoBehaviour
{
    public GameObject playerGameObject;
    public Transform outsideSpawn;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;

    public Transform pos1;
    public Transform pos2;
    public Transform pos3;

    private bool doOnce1 = false;
    private bool doOnce2 = false;
    private bool doOnce3 = false;
    private NavMeshAgent agent;
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        int cp = playerGameObject.GetComponent<playerCheckpoints>().currentCP;
        
        UnityEngine.Vector3 playerPosition = playerGameObject.transform.position;

        if(!doOnce1){
            if((playerPosition.x <= pos1.position.x + 1 && playerPosition.x >= pos1.position.x - 1) 
            && (playerPosition.z <= pos1.position.z + 1 && playerPosition.z >= pos1.position.z - 1)){
                // place Temoc at spawn1 position
                UnityEngine.Debug.Log("Temoc spawned at 1");    
                agent.Warp(spawn1.transform.position);
                //play MJ sound
                doOnce1 = true;
                
            }
        }
        if(!doOnce2){
            if((playerPosition.x <= pos2.position.x + 1 && playerPosition.x >= pos2.position.x - 1) 
            && (playerPosition.z <= pos2.position.z + 1 && playerPosition.z >= pos2.position.z - 1)){
                // place Temoc at spawn1 position
                UnityEngine.Debug.Log("Temoc spawned at 2");    
                agent.Warp(spawn2.transform.position);
                //play MJ sound
                doOnce2 = true;
                
            }
        }
        if(!doOnce3){
            if((playerPosition.x <= pos3.position.x + 1 && playerPosition.x >= pos3.position.x - 1) 
            && (playerPosition.z <= pos3.position.z + 1 && playerPosition.z >= pos3.position.z - 1)){
                // place Temoc at spawn1 position
                UnityEngine.Debug.Log("Temoc spawned at 3");    
                agent.Warp(spawn3.transform.position);
                //play MJ sound
                doOnce3 = true;
                
            }
        }
        
    }

}
