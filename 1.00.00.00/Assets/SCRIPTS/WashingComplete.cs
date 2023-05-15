using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingComplete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject openMachine = GameObject.Find("OpenMachine");
        WashController washController = openMachine.GetComponent<WashController>();  //find these scripts and objects
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject openMachine = GameObject.Find("OpenMachine");
        WashController washController = openMachine.GetComponent<WashController>(); //same as in start method

        //if (washController.washingComplete)
        {
            //Destroy(gameObject);
        }



    }

}
