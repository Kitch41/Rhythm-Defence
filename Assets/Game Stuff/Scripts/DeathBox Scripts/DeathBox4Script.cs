using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox4Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
			transform.position = new Vector3(77.7f, -2.5f, -111.3f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(77.7f, -2.5f, -111.3f);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position = new Vector3(77.7f, -2.5f, -111.3f);
        }


        if (Input.GetKeyUp(KeyCode.F))
        {
            transform.position = new Vector3(77.7f, -2.5f, -350);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            transform.position = new Vector3(77.7f, -2.5f, -350);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position = new Vector3(77.7f, -2.5f, -350);
        }

    }
    private void OnTriggerEnter(Collider Death)
    {
        Destroy(Death.gameObject);
    }

}
