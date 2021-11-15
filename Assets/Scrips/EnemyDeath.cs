using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    //Theos programmering. Scripten ska placeras p� alla enemies.
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
        //N�r objektet som denna script ligger p� (Enemy) nuddar en trigger med taggen "bullet"...
        if (other.tag == "bullet")
        {
            //...s� stannar enemy:n helt...
            rb.constraints = RigidbodyConstraints.FreezeAll;
            //...d�dsanimationen spelas...
            animator.SetBool("Death", true);
            Debug.Log("Gone");
            //..."bullet"-objektet f�rst�rs...
            Destroy(other.gameObject);
            //...enemy:n f�rst�rs efter 0.3 sekunder...
            Destroy(gameObject, 0.3f);
            //...metoden "EnemyShake" spelas (se "CameraShake" scriptet f�r mer info p� metoden)...
            FindObjectOfType<CameraShake>().EnemyShake();
            //...spelarens score g�r upp med 0.5 po�ng...
            FindObjectOfType<ScoreManager>().score += 0.5f;
            //...och ljudet "Enemy Death" spelas.
            FindObjectOfType<AudioManager>().Play("Enemy Death");
        }

        //Om enemy:n nuddar en trigger med taggen "Player"...
        if (other.tag == "Player")
        {
            //...s� spelas d�dsanimationen...
            animator.SetBool("Death", true);
            Debug.Log("Gone");
            //...och enemy:n f�rst�rs efter 0.3 sekunder.
            Destroy(gameObject, 0.3f);
        }
    }

}


