using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    public Text FPS;
    public Text Number;
    public GameObject sphere;

    [NonSerialized]
    public float fps;
    public int number = 15000;
    public int bound = 50;

    private float ttime = 0;
    private int indexx = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<number; i++)
        {
            Instantiate(sphere, GetRandomPosition(), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.indexx % 60 == 0)
        {
            if (ttime != 0)
            {
                FPS.text = "FPS: " + indexx / ttime;
            }
            
            ttime = 0;
            indexx = 0;
        }

        ttime += Time.deltaTime;
        indexx++;
    }

    Vector3 GetRandomPosition()
    {
        float x = bound * (UnityEngine.Random.value - 0.5f);
        float z = bound * (UnityEngine.Random.value - 0.5f);
        
        Vector3 pos = new Vector3(x, 0, z);

        return pos;
    }
}
