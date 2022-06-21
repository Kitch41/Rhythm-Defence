using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesScript : MonoBehaviour
{
    public int lives = 5;
	TextMeshProUGUI text;
    public GameObject endPanel;
    public GameObject portal1;
    public GameObject portal2;
    public GameObject portal3;
    public GameObject portal4;

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
			endPanel.SetActive(true);
			portal1.SetActive(false);
			portal2.SetActive(false);
			portal3.SetActive(false);
		}
	}

	public void Start()
	{
		text = GetComponent<TextMeshProUGUI>();
		text.text = "Lives: " + lives;
		endPanel.SetActive(false);
		portal1.SetActive(true);
		portal2.SetActive(true);
		portal3.SetActive(true);
	}

	public void Update()
	{
		EndGame();
	}
}
