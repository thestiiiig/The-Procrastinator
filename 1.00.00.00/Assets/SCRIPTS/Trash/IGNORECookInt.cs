using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CookingInteraction : MonoBehaviour
{
    public bool isInRange;
    public KeyCode InteractKey;
    public UnityEvent interactAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(InteractKey))
            {
                interactAction.Invoke();

            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Charlie is now in the range of cooking");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Charlie is NOT in the range of cooking");
        }
    }

}
