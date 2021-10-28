using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    //public Rigidbody theRB;
    public float jumForce;
    public CharacterController controller;
    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        //theRB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
        // if (Input.GetButtonDown("Jump"))
        // {
        //     theRB.velocity = new Vector3(theRB.velocity.x, jumForce, theRB.velocity.z);
        // }
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);
        if (Input.GetButtonDown("Jump")){
            moveDirection.y = jumForce;
        }
        moveDirection.y = moveDirection.y + Phy
        controller.Move(moveDirection * Time.deltaTime);
    }
}
