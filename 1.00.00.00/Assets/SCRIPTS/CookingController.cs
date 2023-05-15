using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingController : MonoBehaviour
{

    public bool isInRange; //is in range
    public bool cookingComplete = false;
    public float cookTimer = 20.0f;
    public bool CookingCountStarted = false;
    public bool cookingEnabled = true;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (cookingEnabled) //Cooking hasn't been done before
		{
            if (isInRange) //while player in range of washing
            {
                if (Input.GetButtonDown("E")) //while the player clicks
                {
                    this.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("TopMission"); //bring the cooking pot up
                    CookingCountStarted = true; //the cooking timer has begun
                }
            }
        }   
        if (CookingCountStarted == true) //while the timer has begun
        {
            if (cookTimer >= 0)
            {
                cookTimer -= Time.deltaTime;  //If the timer has ended, the below code will remove the cooking pot.
                if (cookTimer <= 0)
                {
                    cookingComplete = true;
                    this.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("Backgrounds"); //end the cooking

                    Debug.Log("The cooking timer has ended");
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //detect if the player is in range
        {
            isInRange = true;
            Debug.Log("Charlie is now in the range of cooking");
        }
    }

    void OnTriggerExit2D(Collider2D collision) //detect if the player is NOT in range
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Charlie is NOT in the range of cooking");
        }
    }
}
