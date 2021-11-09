using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    //Inte min script, men jag har gjort allt med Animation och Ljud.

    public Animator animator;
    public int health = 3;
    public Text text;
  //  public GameObject heart;

   
    void Update()
        
    {
        text.text = "Health " + health;
        if(health == 0)
        {
            animator.SetBool("Death", true);
            FindObjectOfType<Menu>().Dead();
            FindObjectOfType<ScoreManager>().LoadScore();
            health -= 1;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")  //om den collidar med player så förlorar playernett liv- Emma
        {
            Destroy(other.gameObject, 1);
            HealthDown();
          //  Destroy(heart);


        }
    }

    public void HealthDown()
    {
        health -= 1;
        FindObjectOfType<AudioManager>().Play("Player Hurt");
        FindObjectOfType<CameraShake>().PlayerShake();
    }
}
