using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    //Theos programmering
    //Denna script �r till f�r att spela musiken i spelet. Det fanns inget enkelt s�tt att spela gameplay-musiken vid r�tt tid...
    //...s� jag gjorde bara en ny script och satte den p� ett empty objekt i gameplayscenen s� att musiken b�rjar spelas direkt n�r scenen �ppnas.

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Gameplay Music");
        FindObjectOfType<AudioManager>().Play("Pause Music");
        FindObjectOfType<AudioManager>().Mute("Pause Music");
    }

}
