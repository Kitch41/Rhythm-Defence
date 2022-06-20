using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox2Script : MonoBehaviour
{

    [SerializeField] ComboScript combo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(382.926f, 0.46f, 90.15001f);
        }

        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(382.926f, 0.46f, 90.15001f);
        }
 
      
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position = new Vector3(400f, 0.46f, 90.15001f);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.position = new Vector3(400f, 0.46f, 90.15001f);
        }
        

    }
    private void OnTriggerEnter(Collider Death)
    {
        Death.GetComponent<EnemyMove>().OnDeath();
        combo.AddCombo(1);
        Destroy(Death.gameObject);
    }

}
