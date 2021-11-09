using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    //Theos programmering

    //En public string som heter "namn". Den �r till f�r att kunna n�mna l�ter och ljud.
    public string name;

    //Ett public AudioClip som heter "clip". I den ska man kunna l�gga in sitt ljud man vill spela.
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool mute = false;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
