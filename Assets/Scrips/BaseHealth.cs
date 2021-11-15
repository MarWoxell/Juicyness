using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    //Inte min script, men jag har gjort allt med Animation och Ljud - Theo.

    public Animator animator;
    public int health = 3;
    public Text text;
  //  public GameObject heart;

   
    void Update()
        
    {
        text.text = "Health " + health;
        if(health == 0)
        {
            //"Death" är en bool som jag har skapat med hjälp av "animator" verktyget i Unity. Den bool:en ser till att en animation spelas när den är satt till "true". - Theo
            animator.SetBool("Death", true);
            //"FindObjectOfType" låter dig hitta andra scripts och använda en metod från den scripten. Här ser den till att dödsmenyn dyker upp...
            //...och att den visar poängen när if-satsen sker. - Theo
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
