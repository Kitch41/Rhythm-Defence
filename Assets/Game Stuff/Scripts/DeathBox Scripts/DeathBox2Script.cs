using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox2Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(-11, 3, -278);
        }

        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(-11, 3, -278);
        }
 
      
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position = new Vector3(0, 0, -350);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.position = new Vector3(0, 0, -350);
        }
        

    }
    private void OnTriggerEnter(Collider Death)
    {
        Destroy(Death.gameObject);
    }

}
