using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Cap : MonoBehaviour
{
    //Variables
    public float forceamt = 5f;

    private int i = 7;

    private Rigidbody2D capsule;

    // Start is called before the first frame update
    void Start()
    {
        //Find rigidbody that this script is on
        capsule = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If statement to move right on screen by using D
        if (Input.GetKey(KeyCode.D))
        {
            //Make rigidbody move right
            capsule.AddForce(Vector2.right *  forceamt);
        }

        //If statement to make rigidbody move to the left
        if (Input.GetKey(KeyCode.A)) 
        {
            //Make the rigidbody go left
            capsule.AddForce(Vector2.left * forceamt);
        }

        //If statement to make rigidbody move down
        if (Input.GetKey(KeyCode.S)) 
        {
            //Make rigidbody go down
            capsule.AddForce(Vector2.down * forceamt);
        }

        //If statement to make rigidbody move up
        if (Input.GetKey(KeyCode.W)) 
        {
            //Make rigidboyd go up
            capsule.AddForce(Vector2.up * forceamt);
        }
    }

    //On collisionenter2D, happens when two 2D objects with colliders hit each other
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Make the cube change color when it hits the player 2 cube
        if (collision.transform.tag == "Player 1")
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
        }
    }
}
