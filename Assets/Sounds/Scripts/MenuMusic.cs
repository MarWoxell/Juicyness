using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    //Theos programmering
    //Denna script är till för att spela musiken i spelet. Det fanns inget enkelt sätt att spela gameplay-musiken vid rätt tid...
    //...så jag gjorde bara en ny script och satte den på ett empty objekt i gameplayscenen så att musiken börjar spelas direkt när scenen öppnas.

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Gameplay Music");
        FindObjectOfType<AudioManager>().Play("Pause Music");
        FindObjectOfType<AudioManager>().Mute("Pause Music");
    }

}
