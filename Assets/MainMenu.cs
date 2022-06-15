using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayGame ()
	{
		SceneManager.LoadScene("LevelMenu");
	}

	public void PlayLevel01()
	{
		SceneManager.LoadScene("Level01");
	}

	public void QuitGame ()
	{
		Debug.Log("Quit Game");
		Application.Quit();
	}


}
