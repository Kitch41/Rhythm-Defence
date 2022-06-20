using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox4Script : MonoBehaviour
{

    [SerializeField] ComboScript combo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
			transform.position = new Vector3(382.926f, 0.46f, 95.84f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(382.926f, 0.46f, 95.84f);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position = new Vector3(382.926f, 0.46f, 95.84f);
        }
        else
		{
            transform.position = new Vector3(400f, 0.46f, 95.84f);
        }


        if (Input.GetKeyUp(KeyCode.F))
        {
            transform.position = new Vector3(400f, 0.46f, 95.84f);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            transform.position = new Vector3(400f, 0.46f, 95.84f);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position = new Vector3(400f, 0.46f, 95.84f);
        }

    }
    private void OnTriggerEnter(Collider Death)
    {
        Death.GetComponent<EnemyMove>().OnDeath();
        combo.AddCombo(1);
        Destroy(Death.gameObject);
    }

}
