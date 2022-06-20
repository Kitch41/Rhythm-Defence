using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox3Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(51.1f, -2.5f, -111.3f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(51.1f, -2.5f, -111.3f);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position = new Vector3(51.1f, -2.5f, -111.3f);
        }


        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position = new Vector3(51.1f, -2.5f, -350);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            transform.position = new Vector3(51.1f, -2.5f, -350);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.position = new Vector3(51.1f, -2.5f, -350);
        }

    }
    private void OnTriggerEnter(Collider Death)
    {
        Destroy(Death.gameObject);
    }
}
