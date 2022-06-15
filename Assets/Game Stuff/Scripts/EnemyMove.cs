using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	[HideInInspector] public bool inGreen = false;
	[HideInInspector] public bool inOrange = false;
	[HideInInspector] public bool inRed = false;

	public float speedModifier;

	// Start is called before the first frame update
	void Start()
	{
		speedModifier = 10f;

	}

	// Update is called once per frame
    void Update()
    {
		//transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
		transform.position -= transform.forward * (speedModifier * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Sword")
		{
            Destroy(gameObject);
		}
	}

    private void OnDeath()
	{
		//Add points depending on color...
		if (inGreen)
		{
			//Add 20 points
		}
		else if (inOrange)
		{
			//Add 10 points
		}
		else if (inRed)
		{
			//Add 5 points
		}
	}
}
