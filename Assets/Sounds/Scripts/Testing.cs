using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    //Theos programmering. Den var bara anv�nd som test inf�r linjen av kod nedan.

    // Start is called before the first frame update
    void Start()
    {
        //Hittar scripten "AudioManager" och anv�nder funktionen "Play" fr�n den scripten vilket i sun tur spelar l�ten eller ljudet man har valt...
        //... I detta fall �r det musiken "Start Menu Music".
        FindObjectOfType<AudioManager>().Play("Start Menu Music");
    }

    // Update is called once per frame
    void Update()
    {
        //Anv�nde det h�r (en bit kod som g�r att n�got h�nder om man trycker p� S) f�r att testa ifall ljud och musik fungerade eller inte.
        if (Input.GetKey(KeyCode.S))
        {
            
        }
    }
}
