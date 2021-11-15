//H�r, precis som i Sound-scripten, anv�nder jag ocks� "UnityEngine.Audio".
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Theos programmering

    //Skapar en public array av klassen "Sound" som vi d�per till "sounds". Den g�r en array med allting som finns i "Sound" scripten, som "volym", "pitch" etc.
    public Sound[] sounds;

    // Awake �r som "start" metoden, f�rutom att den anv�nds precis innan allt startar. (Thank you to Brackeys for explaining that to me).
    void Awake()
    {
        //"s" st�r f�r ljudet vi kollar p� vid det tillf�llet.
        //Vad denna kod g�r �r att den loopar igenom alla ljud i array:en och l�gger till en AudioSource p� dem...
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            //...och sedan s� kopierar den �ver "clip", "volume" etc till alla olika AudioSources.
            //S� nu kan man styra �ver ljudet p� just det ljudklippet.
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.mute = s.mute;
        }
    }

    //En "Play" Method. N�r man call:ar p� denna metoden s� spelar den ljudet/musiken av namnet som du givit. 
    public void Play (string name)
    {
        //It browses through the array with "Array.Find" to find the sound with a specific name. 
        //Den bl�ddrar igenom array:en med "Array.Find" f�r att hitta ett ljud ("sound") med ett specifikt namn ("name"). 
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    //Samma som "Play" metoden f�rutom att man tystar det specifika ljudet ist�llet f�r att spela det.
    public void Mute (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.mute = true;
    }

    //Samma som "Mute" metoden f�rutom att man tar bort tystnad fr�n ett ljud ist�llet f�r att tysta det.
    public void UnMute (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.mute = false;
    }
}
