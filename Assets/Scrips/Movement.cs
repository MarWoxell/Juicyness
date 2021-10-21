using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float V = 5.9f;
    public float R = -5.9f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {

            gameObject.transform.position += new Vector3(V, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(R, 0, 0);

        }

        if (transform.position.x > 3.9)
            transform.position = new Vector3(V, transform.position.y, transform.position.z);
        if (transform.position.x < -3.9)
            transform.position = new Vector3(R, transform.position.y, transform.position.z);
    }


}