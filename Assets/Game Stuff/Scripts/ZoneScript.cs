using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour
{
    public enum zoneType
	{
		Green,
		Orange,
		Red
	}

	public zoneType type;

	private void OnTriggerEnter(Collider other)
	{
		EnemyMove EM = other.GetComponent<EnemyMove>();

		if (EM != null)
		{
			switch (type)
			{
				case zoneType.Green:
					EM.inGreen = true;
					break;

				case zoneType.Orange:
					EM.inOrange = true;
					break;

				case zoneType.Red:
					EM.inRed = true;
					break;
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		EnemyMove EM = other.GetComponent<EnemyMove>();

		if (EM != null)
		{
			switch (type)
			{
				case zoneType.Green:
					EM.inGreen = false;
					break;

				case zoneType.Orange:
					EM.inOrange = false;
					break;

				case zoneType.Red:
					EM.inRed = false;
					break;
			}
		}
	}
}
