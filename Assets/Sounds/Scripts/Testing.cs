using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    //Theos programmering. Den var bara använd som test inför linjen av kod nedan.

    // Start is called before the first frame update
    void Start()
    {
        //Hittar scripten "AudioManager" och använder funktionen "Play" från den scripten vilket i sun tur spelar låten eller ljudet man har valt...
        //... I detta fall är det musiken "Start Menu Music".
        FindObjectOfType<AudioManager>().Play("Start Menu Music");
    }

    // Update is called once per frame
    void Update()
    {
        //Använde det här (en bit kod som gör att något händer om man trycker på S) för att testa ifall ljud och musik fungerade eller inte.
        if (Input.GetKey(KeyCode.S))
        {
            
        }
    }
}
