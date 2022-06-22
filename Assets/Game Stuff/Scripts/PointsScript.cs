using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsScript : MonoBehaviour
{
	public int points = 0;
	TextMeshProUGUI pointstext;

	public void GetPoints (int pointsvalue)
	{
		pointstext = GetComponent<TextMeshProUGUI>();
		points += pointsvalue;

		pointstext.text = "Points: " + points;
	}

	public void Start()
	{
		pointstext = GetComponent<TextMeshProUGUI>();
		pointstext.text = "Points: " + points;
		points = PlayerPrefs.GetInt("Points");
	}

 
}
