using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Much like the start() and Update() methods, OnTriggerEnter2D is a special Unity method that is called
    //by unity automatically at a specific point - in this case, when something enters the Trigger attached
    //to this GameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the GameObject that has collided with our trigger is tagged with CleanUp...
        if (collision.gameObject.tag == "CleanUp")
        {
            //then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }

}