using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagPreventor : MonoBehaviour
{
    //Jag inser nu att denna script �r relativt oanv�ndbar, men den f�r vara kvar - Theo
    //Denna script ser till s� att alla skott som �ker f�rbi fienderna f�rst�rs och f�rsvinner n�r de nuddar den �vre bordern. 

    public GameObject Bullet;

    //"OnTriggerEnter" betyder att n�got h�nder om objektet med scripten p� nuddar en "trigger". 
    //Det funkar ocks� om script-objektet �r en trigger och n�got annat nuddar den.
    void OnTriggerEnter(Collider other)
    {
        //Om ett objekt med taggen "bullet" nuddar denna "trigger" s�...
        if (other.tag == "bullet")
        {
            //...f�rst�rs det objektet.
            Destroy(other.gameObject);
        }
    }

}
