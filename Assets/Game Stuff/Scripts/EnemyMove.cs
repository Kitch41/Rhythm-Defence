using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	[HideInInspector] public bool inGreen = false;
	[HideInInspector] public bool inOrange = false;
	[HideInInspector] public bool inRed = false;

	PointsScript points;

	public float speedModifier;

	// Start is called before the first frame update
	void Start()
	{
		points = GameObject.Find("PointText").GetComponent<PointsScript>();
		speedModifier = speedModifier * 10f;

	}

	// Update is called once per frame
    void Update()
    {
		//transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
		transform.position -= transform.forward * (speedModifier * Time.deltaTime);
    }

    public void OnDeath()
	{
		//Add points depending on color...
		if (inGreen)
		{
			points.GetPoints(20);
		}
		else if (inOrange)
		{
			points.GetPoints(5);
		}
		else if (inRed)
		{
			points.GetPoints(0);
		}
	}
}
