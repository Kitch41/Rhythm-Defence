using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SpectrumSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public AudioMixer muteTicks;
    public AudioSource ticks;
    


    private float[] samples = new float[1024];
    public GameObject[] spawnPoints;


     void Start()
    {

        muteTicks.SetFloat("muteVolume", -50);
        
    }

    private void Awake()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
        
    }
    // Update is called once per frame
    void Update()
    {
        
            float[] spectrum = new float[256];
            AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);

        for (int i = 0; i < spectrum.Length; i++)
        {
            float tmp = spectrum[i] * 80;
            Debug.Log(tmp);
            if (tmp > 0.01)
            {
                
                SpawnObject();
            }
        } 
    }

    public void SpawnObject()
    {

        if (checkObject())
        {
            int spawn = Random.Range(0, spawnPoints.Length);
            Instantiate(objectToSpawn, spawnPoints[spawn].transform.position, spawnPoints[spawn].transform.rotation);
        }
    }

    bool checkObject()
    {
        foreach (GameObject obj in Object.FindObjectsOfType(typeof(GameObject)))
        {
            if (obj.name == "ZombieEnemy(Clone)")
            {
                if (obj.transform.position.x >= 359f && obj.transform.position.x <= 360f)
                {
                    return false;
                }
            }
        }
        
        return true;
    }


    //void FixedUpdate()
    //{
    //    //Debug.Log(Time.fixedDeltaTime);
    //}

    //void LoopSpectrum()
    //{
    //    float[] spectrum = new float[256];
    //    AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);


    //    for (int i = 0; i < spectrum.Length; i++)
    //    {
    //        float tmp = spectrum[i] * 3;
    //        if (tmp > 0.2f)
    //        {
    //            SpawnObject();
    //        }
    //    }
    //}

}
