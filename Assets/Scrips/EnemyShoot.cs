using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemy;
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Trigger")  //om den kommer utanf�r mappen till en trigger box s� f�rsvinner objeketet
        {
            Destroy(other.gameObject);
        }
      
    }
}


