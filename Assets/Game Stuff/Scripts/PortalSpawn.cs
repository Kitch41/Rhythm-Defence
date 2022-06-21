using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PortalSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float timeToSpawn;

    public float currentTimeToSpawn;

    private bool waiter = false;
    // Start is called before the first frame update
     void Start()
    {
        new WaitForSeconds(5);
        waiter = true;
        //Task longRunningTask = Waiter();
        //// independent work which doesn't need the result of LongRunningOperationAsync can be done here

        ////and now we call await on the task 
        //await longRunningTask;
    }

    async Task Waiter()
    {
        new WaitForSeconds(22);
        Debug.Log("Test");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waiter)
        {
            if (currentTimeToSpawn > 0)
            {
                currentTimeToSpawn -= Time.deltaTime;
            }
            else
            {
                SpawnObject();
                currentTimeToSpawn = timeToSpawn;
            }
            //Debug.Log("Oh shit");
        }
        
    }

    public void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
