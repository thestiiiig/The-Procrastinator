using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string NextScene;
    public void PlayGame ()
    {
        //load next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //open the next scene on the build index
    }

    public void OpenControls()
    {
        SceneManager.LoadScene(NextScene); //Load Controls screen
    }

    public void QuitGame()
	{
        Debug.Log("The game has been closed."); 
        Application.Quit(); //The application closes.
	}

    public void ToCredits()
	{

        SceneManager.LoadScene("Credits"); //Load credits screen

	}
}
