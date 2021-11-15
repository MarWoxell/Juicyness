using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderHealth : MonoBehaviour
{
    //Theos programmering
    //Denna script ser till att alla enemies som nuddar den lägre bordern dör...
    //...den ser också till att spelarens liv går ner när en enemy nuddar lägre bordern.

    public GameObject Enemy1;
    public GameObject Enemy2;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            FindObjectOfType<BaseHealth>().HealthDown();
        }
    }

}
