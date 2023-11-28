using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject imageObject;
    public Transform endPos;

    void Start(){
        imageObject.SetActive(false);
    }

    void Update(){
        if ((gameObject.transform.position.x <= endPos.transform.position.x+1 
            && gameObject.transform.position.x >= endPos.transform.position.x-1) &&
            (gameObject.transform.position.z <= endPos.transform.position.z+1 
            && gameObject.transform.position.z >= endPos.transform.position.z-1)){
            agent.SetDestination(new UnityEngine.Vector3(0,0,0));
            imageObject.SetActive(true);
            AudioSource endsound = gameObject.GetComponent<AudioSource>();
            endsound.Play();
            //play sound
        }
    }
}
