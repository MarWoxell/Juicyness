using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    //Theos programmering

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
        if (other.tag == "bullet")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            animator.SetBool("Death", true);
            Debug.Log("Gone");
            Destroy(other.gameObject);
            Destroy(gameObject, 0.3f);
            FindObjectOfType<CameraShake>().EnemyShake();
            FindObjectOfType<ScoreManager>().score += 0.5f;
            FindObjectOfType<AudioManager>().Play("Enemy Death");
        }

        if (other.tag == "Player")
        {
            animator.SetBool("Death", true);
            Debug.Log("Gone");
            Destroy(gameObject, 0.3f);
        }
    }

}


