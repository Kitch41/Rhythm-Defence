using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesScript : MonoBehaviour
{
    public int lives = 5;
	TextMeshProUGUI text;

    public void TakeDamage(int damage)
	{
		lives -= damage;
		
		if (lives < 0)
		{
			//endgame
		}

		text.text = "Lives: " + lives;
	}

	public void Start()
	{
		text = GetComponent<TextMeshProUGUI>();
		text.text = "Lives: " + lives;
	}
}
