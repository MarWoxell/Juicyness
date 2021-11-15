using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagPreventor : MonoBehaviour
{
    //Jag inser nu att denna script är relativt oanvändbar, men den får vara kvar - Theo
    //Denna script ser till så att alla skott som åker förbi fienderna förstörs och försvinner när de nuddar den övre bordern. 

    public GameObject Bullet;

    //"OnTriggerEnter" betyder att något händer om objektet med scripten på nuddar en "trigger". 
    //Det funkar också om script-objektet är en trigger och något annat nuddar den.
    void OnTriggerEnter(Collider other)
    {
        //Om ett objekt med taggen "bullet" nuddar denna "trigger" så...
        if (other.tag == "bullet")
        {
            //...förstörs det objektet.
            Destroy(other.gameObject);
        }
    }

}
