using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code, if any, goes here.
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}

