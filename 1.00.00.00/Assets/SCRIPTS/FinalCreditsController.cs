using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCreditsController : MonoBehaviour
{

	public void QuitGame()
	{
		Application.Quit();                 //exit game
		Debug.Log("QUIT!!!!!!!!!!!");

	}

	public void BackToMenu()
	{
		SceneManager.LoadScene("MenuScreen");  //back to menu! no game reset.
	}
}
