using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagPreventor : MonoBehaviour
{
    //Jag inser nu att denna script �r relativt oanv�ndbar, men den f�r vara kvar - Theo

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
