using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody theRB;
    public float jumForce;
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
        if 
    }
}
