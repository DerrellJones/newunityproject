using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    public float jumpForce = 500f;

    float maxSpeed = 10.0f;
    bool isOnGround = false;
     
    //Create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerobject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidybody2D component that is attached to the same object as this script
        playerobject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 10.0f;
        }
        else
        {
            maxSpeed = 4.0f;
        }

        //Create a 'float' that will be equal to the players horizontal input
        float movementValueX = 1.0f;

        //change the X velocity of the Rigidbody2D to be equal to the movement value
        playerobject.velocity = new Vector2(movementValueX * maxSpeed, playerobject.velocity.y);

        //Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerobject.AddForce(new Vector2(0.0f, jumpForce));
        }
    }
}
