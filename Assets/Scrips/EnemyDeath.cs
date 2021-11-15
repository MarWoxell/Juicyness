using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    //Theos programmering. Scripten ska placeras på alla enemies.
    //Markus skrev om Camerashaken och ScoreManagern.

    public GameObject Player;
    public GameObject Bullet;
    public Animator animator;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        //När objektet som denna script ligger på (Enemy) nuddar en trigger med taggen "bullet"...
        if (other.tag == "bullet")
        {
            //...så stannar enemy:n helt...
            rb.constraints = RigidbodyConstraints.FreezeAll;
            //...dödsanimationen spelas...
            animator.SetBool("Death", true);
            Debug.Log("Gone");
            //..."bullet"-objektet förstörs...
            Destroy(other.gameObject);
            //...enemy:n förstörs efter 0.3 sekunder...
            Destroy(gameObject, 0.3f);
            //...metoden "EnemyShake" spelas (se "CameraShake" scriptet för mer info på metoden)...
            FindObjectOfType<CameraShake>().EnemyShake();
            //...spelarens score går upp med 0.5 poäng...
            FindObjectOfType<ScoreManager>().score += 0.5f;
            //...och ljudet "Enemy Death" spelas.
            FindObjectOfType<AudioManager>().Play("Enemy Death");
        }

        //Om enemy:n nuddar en trigger med taggen "Player"...
        if (other.tag == "Player")
        {
            //...så spelas dödsanimationen...
            animator.SetBool("Death", true);
            Debug.Log("Gone");
            //...och enemy:n förstörs efter 0.3 sekunder.
            Destroy(gameObject, 0.3f);
        }
    }

}


