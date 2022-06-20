using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox1Script : MonoBehaviour
{

    [SerializeField] ComboScript combo;

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
                    transform.position = new Vector3(382.926f, 0.46f, 87.4f);
                }
  
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(382.926f, 0.46f, 87.4f);
                }
                




                if (Input.GetKeyUp(KeyCode.A))
                {
                    transform.position = new Vector3(400f, 0.46f, 87.4f);
                }
                
                if (Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(400f, 0.46f, 87.4f);
                }



    }
    private void OnTriggerEnter(Collider Death)
    {
        Death.GetComponent<EnemyMove>().OnDeath();
        combo.AddCombo(1);
        Destroy(Death.gameObject);
    }
}
