using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawnTest : MonoBehaviour
{
    float timeLastFrame = 0;
    float deltaTime = 10;

    //float speed = 0;

    public AudioSource musicAudioSource;
    public GameObject objectToSpawn;
    
    void Start()
    {
        InvokeRepeating("SpawnObject", 3.0f, 0.345f);
    }

    void Update()
    {
        // Detect how much time has passed in the song
        deltaTime = musicAudioSource.time - timeLastFrame;
        timeLastFrame = musicAudioSource.time;
        Debug.Log(timeLastFrame.ToString("F0"));

        // Move forward at your speed based on how much time has passed in the music
        //transform.position += Vector3.forward * speed * deltaTime;
        

    }

     void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
