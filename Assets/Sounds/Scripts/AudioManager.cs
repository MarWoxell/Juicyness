using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Theos programmering

    //Skapar en public array av klassen "Sound" som vi döper till "sounds". Den gör en array med allting som finns i "Sound" scripten, som "volym", "pitch" etc.
    public Sound[] sounds;

    // Awake är som "start" metoden, förutom att den används precis innan allt startar. (Thank you to Brackeys for explaining that to me).
    void Awake()
    {
        //"s" står för ljudet vi kollar på vid det tillfället.
        //Vad denna kod gör är att den loopar igenom alla ljud i array:en och lägger till en AudioSource på dem...
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            //...och sedan så kopierar den över "clip", "volume" etc till alla olika AudioSources.
            //Så nu kan man styra över ljudet på just det ljudklippet.
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.mute = s.mute;
        }
    }


    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Mute (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.mute = true;
    }

    public void UnMute (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.mute = false;
    }
}
