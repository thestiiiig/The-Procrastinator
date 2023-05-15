using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashController : MonoBehaviour
{
    //the variables required for this task
    public bool isInRange;
    public bool washingComplete = false;
    public float washTimer = 20.0f;
    public bool WashingCountStarted = false;
    public bool washingEnabled = true;

    void Awake()
    {
        DontDestroyOnLoad(transform.root.gameObject); //dont destroy this object when entering new scenes

    }

    // Update is called once per frame
    void Update()
    {
        GameObject CookingPot = GameObject.Find("CookingPot"); //Finding objects from other scripts:
        CookingController CookingController = CookingPot.GetComponent<CookingController>();  //find this object


        top:
        if (CookingController == null)
		{
            Debug.Log("Cooking Controller is null"); //check for null
		}
        else if (CookingPot) //(error in typing code)(too late to fix)
        {
            goto bottom;    //the pot is found so skip this section
        }
        else
        {
            Debug.Log("NoCookingPot found"); //checking for null

            goto top;
        }                                       

        bottom:
        if (CookingPot == null)
		{
            Debug.Log("No cooking pot found");

		}
        else if (CookingPot)
        {
            goto bottom2;
        }
        else
        {
            Debug.Log("No cooking pot found."); //checking for null
            goto bottom;
        }

        bottom2:
        if (washingEnabled)    //Washing hasn't been done before
		{
            if (isInRange) //while player in range of washing
            {
                if (Input.GetButtonDown("E")) //while the player clicks
                {
                    this.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("Backgrounds"); //close the washing machine
                    WashingCountStarted = true;
                    //start the timer


                }
            }
        }
        //bottomTwo:
        if (WashingCountStarted == true) //While the timer has started
        {
            if (washTimer >= 0) //the wash timer has ended
            {
                washTimer -= Time.deltaTime;
                if (washTimer <= 0)                 //if the timer has ended, washing is done, cannot be done again, and the washing machine will be opened.
                {
                    washingComplete = true;
                    washingEnabled = false;
                    this.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("LaundryTopMission"); //open the washing machine

                    Debug.Log("The washing timer has ended");
                }

            }
        }

        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))       //check for in range
        {
            isInRange = true;
            Debug.Log("Charlie is now in the range of washing");
        }
    }

    void OnTriggerExit2D(Collider2D collision)          //check if out of range
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Charlie is NOT in the range of washing");
        }
    }
}
