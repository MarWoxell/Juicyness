using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pang : MonoBehaviour
{
    public GameObject enemy;
     void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Enemy")
        {
            Debug.Log("Hit");
            Destroy(other.gameObject);
        }
    }
}
