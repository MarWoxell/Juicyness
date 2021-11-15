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
            //"Death" �r en bool som jag har skapat med hj�lp av "animator" verktyget i Unity. Den bool:en ser till att en animation spelas n�r den �r satt till "true". - Theo
            animator.SetBool("Death", true);
            //"FindObjectOfType" l�ter dig hitta andra scripts och anv�nda en metod fr�n den scripten. H�r ser den till att d�dsmenyn dyker upp...
            //...och att den visar po�ngen n�r if-satsen sker. - Theo
            FindObjectOfType<Menu>().Dead();
            FindObjectOfType<ScoreManager>().LoadScore();
            health -= 1;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")  //om den collidar med player s� f�rlorar playernett liv- Emma
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
