using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
  
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trigger")  //om den kommer utanf�r mappen till en trigger box s� f�rsvinner objeketet
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.tag == "Player")  //om den collidar med player s� f�rsvinner objektet och playern f�rlorar ett liv
        {
            GameObject playerBase = other.gameObject;
            BaseHealth playerhealth = playerBase.GetComponent<BaseHealth>();
            playerhealth.health -= 1;
            Destroy(gameObject);
        }
    }
}


