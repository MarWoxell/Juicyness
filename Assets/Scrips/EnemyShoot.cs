using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemy;
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Trigger")  //om den kommer utanför mappen till en trigger box så försvinner objeketet
        {
            Destroy(other.gameObject);
        }
      
    }
}


