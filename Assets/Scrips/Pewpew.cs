using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pewpew : MonoBehaviour
{

    public Transform firePoint;
    public GameObject Player;

    private float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(Player, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

}