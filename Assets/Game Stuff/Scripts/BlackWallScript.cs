using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackWallScript : MonoBehaviour
{
    [SerializeField] LivesScript lives;
    [SerializeField] ComboScript combo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        lives.TakeDamage(1);
        combo.LoseCombo();

		Destroy(other.gameObject);
	}
}
