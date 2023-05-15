using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinkController : MonoBehaviour
{
    //these variables are used for this mission
    public bool isInRange;
    public bool dishesComplete = false;
    public float dishesTimer = 20.0f;
    public bool dishesCountStarted = false;
    public bool dishesEnabled = true;


    void Awake()
    {
        //if (eD.GameHasEnded == false)
		{
            DontDestroyOnLoad(transform.root.gameObject); //dont destroy this game object when entering a new scene

        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject WashingMachine = GameObject.Find("WashingMachine"); //Finding objects from other scripts


        uupar:
        if (WashingMachine == null)
		{
            Debug.Log("No WashingMachine Found.");  //checking for null
            return;
        }
        else if (WashingMachine) //if found, go down
		{
            goto neechay;
        }
		else
		{
            Debug.Log("No washing Machine found"); //checking for null
            goto uupar;
		}

        neechay:
        WashController WashingController = WashingMachine.GetComponent<WashController>(); //Finding objects from other scripts

        if (WashingController == null)
		{
            Debug.Log("No washing controller found"); //checking for null
            
		}
        else if (WashingController)  //if found, go down
		{
            goto neechay2;
		}
		else
		{
            Debug.Log("No WashingController found."); //checking for null
            goto neechay;
		}

        neechay2:
        if (dishesEnabled) //if dishes haven't been completed before 
		{
            if (isInRange) //while player in range of dishes
            {
                if (Input.GetButtonDown("E")) //while the player clicks
                {
                    this.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("BottomMission"); //bring 

                    dishesCountStarted = true; //the dish timer has begun

                }
            }
        }
        if (dishesCountStarted == true) //while the timer has begun
        {
            if (dishesTimer >= 0) 
            {
                dishesTimer -= Time.deltaTime;
                if (dishesTimer <= 0)           //if the timer has ended, the task is complete and cannot be started again.
                {
                    dishesComplete = true; //dishes are complete
                    dishesEnabled = false;  //dishes are not enabled any longer
                }
            }
        }

        
    }

    void OnTriggerEnter2D(Collider2D collision)       //check if player is in range
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Charlie is now in the range of dishes");
        }
    }

    void OnTriggerExit2D(Collider2D collision)            //is player out of range
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Charlie is NOT in the range of dishes");
        }
    }
}
