using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoxScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the DestroyBox to a set of coordinates
                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.position = new Vector3(-34, 3, -278);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position = new Vector3(-11, 3, -278);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.position = new Vector3(13, 3, -278);
                }
                if (Input.GetKeyDown(KeyCode.F))
                {
                    transform.position = new Vector3(33, 3, -278);
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(-34, 3, -278);
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    transform.position = new Vector3(-11, 3, -278);
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    transform.position = new Vector3(13, 3, -278);
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.position = new Vector3(33, 3, -278);
                }

        if (Input.GetKeyDown(KeyCode.J))
                {
                    transform.position = new Vector3(13, 3, -278);
                }
                if (Input.GetKeyDown(KeyCode.K))
                {
                    transform.position = new Vector3(33, 3, -278);
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
                if (Input.GetKeyUp(KeyCode.J))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.K))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.UpArrow))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                if (Input.GetKeyUp(KeyCode.RightArrow))
                {
                    transform.position = new Vector3(0, 0, -350);
                }

    }
    private void OnTriggerEnter(Collider Death)
    {
        Destroy(Death.gameObject);
    }
}
