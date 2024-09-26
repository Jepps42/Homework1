using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Transform : MonoBehaviour
{
    //Variables
    public float speed = 5f;

    public GameObject pl2;

    private bool spawn = true;

    //public GameManager gameManager;

    private void Awake()
    {
        pl2 = this.gameObject;
        //gameManager = FindObjectOfType<GameManager>();
    }


    // Update is called once per frame
    /*void Update()
    {
        //Find the object every frame and make a vector
        Vector2 pos = transform.position;


        //If I press right arrow, make the object move to the right
        //If is called every time I press the right arrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }

        //If I press left arrow, make the object move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        //If I press down arrow, make the object go down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }

        //If I press up arrow, make the object go up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }

        //Transform position needs to be in the last line for it to function (hiearchy)
        transform.position = pos;
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (spawn)
        {

            spawn = false;
            if (collision.transform.CompareTag("Player 1"))
            {
                //gameManager.sc_num++;
                GameManager.instance.sc_num++;

            }
            else if (collision.transform.tag == "Player 3")
            {
                //gameManager.p3sc_num++;
                GameManager.instance.p3sc_num++;
            }
            //Spawn a Player 2 at a random location
            var pos = new Vector2(Random.Range(-6, 6), Random.Range(-3, 3));
            Instantiate(pl2, pos, Quaternion.identity);

            //Destroy player
            Destroy(this.gameObject);
            spawn = true;
        }
    }
    
    //x: 8, -8 y: 3, -2.9
}
