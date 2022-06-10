using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	[HideInInspector] public bool inGreen = false;
	[HideInInspector] public bool inOrange = false;
	[HideInInspector] public bool inRed = false;

	[SerializeField] [Range(-0.5f, 0)]private float speedModifier = -0.05f;

	// Start is called before the first frame update
	void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speedModifier;
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
