using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private Transform bullet;
    public float speed;

     void Start()
    {
        bullet = GetComponent<Transform>();
    }
     void FixedUpdate()
    {
        bullet.position += Vector3.up * -speed;
       
        if(bullet.position.y <= -10)
        {
            Destroy(bullet.gameObject);
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log("Player dead");
        }
        else if (other.tag == "Base") {
            GameObject playerBase = other.gameObject;
            BaseHealth basehealth = playerBase.GetComponent<BaseHealth>();
            basehealth.health -= 1;
            Destroy(gameObject);
        }
    }
}


