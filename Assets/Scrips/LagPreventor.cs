using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagPreventor : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
