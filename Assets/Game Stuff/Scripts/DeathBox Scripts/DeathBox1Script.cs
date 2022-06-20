using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox1Script : MonoBehaviour
{

    [SerializeField] ComboScript combo;
    private bool isActive = false;
    private float timer;
    private float maxTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move the DestroyBox to a set of coordinates
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isActive = true;
        }

        if (isActive)
        {
            transform.position = new Vector3(382.926f, 0.46f, 87.4f);
            timer += Time.deltaTime;

            if (timer > maxTime)
            {
                timer = 0;
                transform.position = new Vector3(400f, 0.46f, 87.4f);
                isActive = false;
            }
        }



    }
    private void OnTriggerEnter(Collider Death)
    {
        Death.GetComponent<EnemyMove>().OnDeath();
        combo.AddCombo(1);
        Destroy(Death.gameObject);
    }
}
