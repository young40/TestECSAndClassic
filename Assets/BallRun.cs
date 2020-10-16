using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(Mathf.Sin(Time.timeSinceLevelLoad) * 100, Vector3.up);
        transform.Translate(new Vector3(0, Mathf.Sin(Time.timeSinceLevelLoad) / 100f, 0));
    }
}
