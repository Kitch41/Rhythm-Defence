using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the sword to a set of coordinates
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(-28, 0, -296);
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    transform.position = new Vector3(0, 0, -296);
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.position = new Vector3(30,0, -296);
                }
    }
}
