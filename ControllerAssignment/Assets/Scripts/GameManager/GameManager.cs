using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    //Make it a singleton
    public static GameManager instance;

    public TextMeshProUGUI score;

    public int sc_num;

    public TextMeshProUGUI p3score;

    public int p3sc_num;


    //Awake is called on sopawn of this script before Start
    private void Awake()
    {
        //A singlton must only have one instance, check to make sure this is the only instance
        //If it is, make sure its not destroyed, if its not destroy this instance
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0
        sc_num = 0;
        p3sc_num = 0;
        //score.text = "Score: " + sc_num;
    }

    // Update is called once per frame
    void Update()
    {
       
        score.text = "Score: " + sc_num;
        p3score.text = "Score: " + p3sc_num;
    }
}
