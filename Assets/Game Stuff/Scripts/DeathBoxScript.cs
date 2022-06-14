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
                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.position = new Vector3(-34, 0, -278);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position = new Vector3(0, 0, -296);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.position = new Vector3(30,0, -296);
                }
                if (Input.GetKeyDown(KeyCode.F))
                {
                    transform.position = new Vector3(30,0, -296);
                }


                if (Input.GetKeyUp(KeyCode.A))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.S))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.D))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.F))
                {
                    transform.position = new Vector3(0, 0, -350);
                }

        //Destroy objects
        private void OnTriggerEnter(Collider Death)
        {
                Destroy(Death.gameObject);
        }

    }
}
