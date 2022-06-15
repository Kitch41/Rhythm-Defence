using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox1Script : MonoBehaviour
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
  
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(-34, 3, -278);
                }
                




                if (Input.GetKeyUp(KeyCode.A))
                {
                    transform.position = new Vector3(0, 0, -350);
                }
                
                if (Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(0, 0, -350);
                }

    }
    private void OnTriggerEnter(Collider Death)
    {
        Destroy(Death.gameObject);
    }
}
