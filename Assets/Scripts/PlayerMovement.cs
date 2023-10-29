using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    private float verticalInput;
    private float horizontalInput;
    public float speed;
    private Rigidbody playerRB;
    Vector3 moveDirection;
    public Transform orientation;
    public float gravMod = 1.2f;


    public float groundDrag;
    [Header("Ground Status")]
    public float playerHeight;
    public LayerMask theGround;
    bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerRB.freezeRotation = true;
        Physics.gravity *= gravMod;
    }

    // Update is called once per frame
    void Update()
    {
        // is player on ground?
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, theGround);

        movementInput();
        speedControl();

        // applying drag
        if(grounded)
            playerRB.drag = groundDrag;
        else
            playerRB.drag = 0;

    }

    void FixedUpdate()
    {
        playerMovement();    
    }

    private void movementInput(){
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        
    }

    private void speedControl(){
        Vector3 flatVel = new Vector3(playerRB.velocity.x, 0f, playerRB.velocity.z);

        if(flatVel.magnitude > speed){
            Vector3 velLimit = flatVel.normalized * speed;
            playerRB.velocity = new Vector3(velLimit.x, playerRB.velocity.y, velLimit.z);
        }
    }

    private void playerMovement(){
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        playerRB.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);
    }

}
