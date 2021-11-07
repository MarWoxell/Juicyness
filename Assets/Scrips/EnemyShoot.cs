using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemy;
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Enemy")
        {
            Debug.Log("Gone");
            Destroy(other.gameObject);
        }
    }
}


