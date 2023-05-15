using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackController : MonoBehaviour
{
    public string NextScene; //next scene string


    public void BackToMenu()
    {
        SceneManager.LoadScene(NextScene); //return to menu
    }

}
