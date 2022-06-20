using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int enemySpawned = 0;
    float timer = 0.0f;

    void FixedUpdate()
    {
        timer += Time.smoothDeltaTime;
        string stringTimer = timer.ToString("F0");
        Debug.Log(stringTimer);
        if (stringTimer == "5")
            enemySpawned += 1;
        {
            if(enemySpawned == 1)
            {
                enemySpawned -= 0;
                SpawnObject();
            }
        }
    }
    public void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
