using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public float speed;
    private Rigidbody playerRB;
    private AudioSource playerAudio;
    public float gravMod = 1.2f;
    private Vector3 latestCP;
    public float cameraRotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravMod;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        rotPlayer();
    }

    private void movement(){
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

    private void rotPlayer(){
        
    }
}
