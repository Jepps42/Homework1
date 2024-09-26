using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Cap : MonoBehaviour
{
    //Variables
    public float forceamt = 5f;

    private int i = 7;

    private Rigidbody2D capsule;

    private Color defaultColor = Color.cyan;


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
        if (collision.transform.tag == "Player 2")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }

        //Make the cube change color when it hits player 3 
        if (collision.transform.tag == "Player 3")
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            
        }

        GameManager.instance.StartGame();
    }

    //OnCollisionExit2D, happens when two 2D objects with colliders separate
    private void OnCollisionExit2D(Collision2D collision)
    {
        //Every time we exit, we want object to change back to original color
        GetComponent<SpriteRenderer>().color = defaultColor;
    }
}
