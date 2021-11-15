using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderHealth : MonoBehaviour
{
    //Theos programmering
    //Denna script ser till att alla enemies som nuddar den l�gre bordern d�r...
    //...den ser ocks� till att spelarens liv g�r ner n�r en enemy nuddar l�gre bordern.

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
