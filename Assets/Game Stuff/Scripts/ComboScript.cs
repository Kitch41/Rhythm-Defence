using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComboScript : MonoBehaviour
{
	// Start is called before the first frame update
	public int combo = 0;
	TextMeshProUGUI combotext;

	public void AddCombo(int combovalue)
	{
		combo += combovalue;

		combotext.text = "Combo: " + combo;
	}

	public void LoseCombo()
	{
		combo = 0;
		combotext.text = "Combo: " + combo;
	}


	public void Start()
	{
		combotext = GetComponent<TextMeshProUGUI>();
		combotext.text = "Combo: " + combo;
	}
}
