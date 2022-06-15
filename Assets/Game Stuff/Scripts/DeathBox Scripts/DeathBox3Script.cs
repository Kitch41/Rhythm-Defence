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
            transform.position = new Vector3(13, 3, -278);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(13, 3, -278);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position = new Vector3(13, 3, -278);
        }


        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position = new Vector3(0, 0, -350);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            transform.position = new Vector3(0, 0, -350);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.position = new Vector3(0, 0, -350);
        }

    }
    private void OnTriggerEnter(Collider Death)
    {
        Destroy(Death.gameObject);
    }
}
