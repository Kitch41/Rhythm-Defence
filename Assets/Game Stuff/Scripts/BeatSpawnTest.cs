using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawnTest : MonoBehaviour
{
    float timeLastFrame = 0;
    float deltaTime = 10;

    float speed = 0;

    public AudioSource musicAudioSource;
    public GameObject objectToInstantiate;
    private readonly float timeFromPlayer;

    void Update()
    {
        // Detect how much time has passed in the song
        deltaTime = musicAudioSource.time - timeLastFrame;
        timeLastFrame = musicAudioSource.time;
        Debug.Log(timeLastFrame.ToString("F0"));

        // Move forward at your speed based on how much time has passed in the music
        //transform.position += Vector3.forward * speed * deltaTime;

        
    }

    void MakeObject(float timeFromPlayer)
    {
        // Make a new object
        GameObject newObj = Instantiate(objectToInstantiate) as GameObject;

        // Place the new object a specific distance from the player so it takes "timeFromPlayer" seconds to reach the object
        newObj.transform.position = transform.position + Vector3.left * speed * timeFromPlayer;
    }
}
