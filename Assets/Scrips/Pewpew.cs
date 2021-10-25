using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pewpew : MonoBehaviour
{

    public Transform firePoint;
    public Transform firePoint1;
    public GameObject Player;

    private float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(Player, firePoint.position, firePoint.rotation);
        GameObject bulle = Instantiate(Player, firePoint1.position, firePoint1.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Rigidbody2D rB = bulle.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        rB.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);


    }
}