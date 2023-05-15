using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public string sceneToLoad;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger) //detect player
        {
            SceneManager.LoadScene(sceneToLoad);     //When the player enters one of these colliders, the next scene loads
        }
    }


}
