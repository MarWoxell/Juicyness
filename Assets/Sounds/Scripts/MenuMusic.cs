using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Gameplay Music");
        FindObjectOfType<AudioManager>().Play("Pause Music");
        FindObjectOfType<AudioManager>().Mute("Pause Music");
    }

}
