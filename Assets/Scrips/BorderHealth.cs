using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderHealth : MonoBehaviour
{
    //Theos programmering

    public GameObject Enemy1;
    public GameObject Enemy2;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            FindObjectOfType<BaseHealth>().HealthDown();
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
