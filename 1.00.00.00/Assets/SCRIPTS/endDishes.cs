using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endDishes : MonoBehaviour
{
    private float GameEndDelay = 5f;
    public string HEXLoad;
    public bool GameHasEnded = false;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject); //keep the object awake when entering a different scene
    }

    // Update is called once per frame
    void Update()
    {
        GameObject DirtySink = GameObject.Find("SinkDirty");
        sinkController SinkController = DirtySink.GetComponent<sinkController>();    //Finding objects from other scripts

        if (SinkController.dishesComplete == true)
        {
            this.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("TopMission"); //bring up

        }
        if (SinkController.dishesComplete == true)
        {
            if (GameEndDelay >= 0)  // A delay is added to the end of the final task to make the transition to the ending less abrupt
            {
                GameEndDelay -= Time.deltaTime;
                if (GameEndDelay <= 0)
                {
                    GameHasEnded = true; //game has ended, a notification to destroy all mission objects.

                    //GameObject[] taskitems = GameObject.FindGameObjectsWithTag("TaskItem");
                    //foreach (GameObject Taskitem in taskitems)
                        //GameObject.Destroy(Taskitem);

                    SceneManager.LoadScene(HEXLoad);       //The final game can be loaded

                }

            }
        }

    }
}
