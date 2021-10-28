using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    public int health = 3;
    public int test;
    public Text text;

   
    void Update()
        
    {
        text.text = "Health " + health;
        test = health;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")  //om den collidar med player så försvinner objektet och playern förlorar ett liv
        {

            health -= 1;
            FindObjectOfType<AudioManager>().Play("Player Hurt");


        }
    }
}
