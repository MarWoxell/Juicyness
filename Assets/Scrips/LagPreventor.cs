using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagPreventor : MonoBehaviour
{
    public GameObject Bullet;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);
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
