using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LivesScript : MonoBehaviour
{

	public int lives = 5;
	TextMeshProUGUI text;

    public void TakeDamage(int damage)
	{
		lives -= damage;

       
		
		if (lives <= 0)
		{
            lives = 0;
        }

		text.text = "Lives: " + lives;
	}

	public void EndGame()
	{
		if (lives <= 0)
		{
			SceneManager.LoadScene("EndGame");
		}
	}

	public void Start()
	{
		text = GetComponent<TextMeshProUGUI>();
		text.text = "Lives: " + lives;
	}

	public void Update()
	{
		EndGame();
	}
}
