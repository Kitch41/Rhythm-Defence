using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox3Script : MonoBehaviour
{

    [SerializeField] ComboScript combo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(382.926f, 0.46f, 93.18001f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(382.926f, 0.46f, 93.18001f);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position = new Vector3(382.926f, 0.46f, 93.18001f);
        }


        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position = new Vector3(400f, 0.46f, 93.18001f);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            transform.position = new Vector3(400f, 0.46f, 93.18001f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.position = new Vector3(400f, 0.46f, 93.18001f);
        }

    }
    private void OnTriggerEnter(Collider Death)
    {
        Death.GetComponent<EnemyMove>().OnDeath();
        combo.AddCombo(1);
        Destroy(Death.gameObject);
    }
}
