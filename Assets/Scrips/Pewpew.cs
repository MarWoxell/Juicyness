using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pewpew : MonoBehaviour
{

    public Transform firePoint;
    public Transform firePoint1;
    public GameObject Player;

    private float bulletForce = 20f;
    public int ShootingAmount;
    public float Timer;
    float TimerInstance;

    private void Start()
    {
        TimerInstance = Timer;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i <= ShootingAmount; i++)
            {
                Shoot(i);
            }
        
        }
        Timer -= Time.deltaTime;
        if(Timer <= 0)
        {
            Timer = TimerInstance;
            if(ShootingAmount <= 2)
            {
                ShootingAmount++;
            }
           
        }
    }

    void Shoot(int i)
    {
        GameObject bullet = Instantiate(Player, firePoint.position + new Vector3(i, 0, 0), firePoint.rotation);
        GameObject bulle = Instantiate(Player, firePoint1.position - new Vector3(i, 0, 0), firePoint1.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        Rigidbody rB = bulle.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode.Impulse);
        rB.AddForce(firePoint1.up * bulletForce, ForceMode.Impulse);


    }
}