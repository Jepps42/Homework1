using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        
    }
}
