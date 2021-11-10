//Använder UnityEngine.Audio. En hel del ljud modifieringar finns i detta namnutrymme.
using UnityEngine.Audio;
using UnityEngine;

//När vi tog bort "MonoBehaviour", för att göra klassen custom, så tog vi även bort förmågan för scripten att kunna synas i inspectorn...
//...Därför måste vi markera den som "System.Serializable" vilket gör att den kan synas igen. (Om vi inte gjorde detta så skulle array:en inte kunna synas).
[System.Serializable]
public class Sound
{
    //Theos programmering. En custom klass med en lista av ljud och hur ljuden beter sig. 

    //En public string som heter "namn". Den är till för att kunna nämna låter och ljud.
    public string name;

    //Ett public AudioClip som heter "clip". I den ska man kunna lägga in sitt ljud man vill spela.
    public AudioClip clip;

    //Två public floats som heter "Volume" och "Pitch". De är till för att kunna kontrollera volym och tonhöjd. 
    //"Range" tillåter dig att lägga till ett minimum- och maximumtal på din float så att man inte kan höja det till oändligheten... 
    //...Den skapar också en slider i unity som man kan använda för att höja och sänka "ljudet" i detta fall.
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    //En public bool som heter "mute". Den är till för att kunna tysta vissa ljud. Den är satt på "falskt" för att jag inte vill ha vartenda ljud tystade. 
    // Den är till för bara en sak. Pause musiken. Testa att pausa i spelet så kommer du fatta. 
    public bool mute = false;

    //En public bool som heter "loop". Den är till för att kunna loop:a låtar. 
    public bool loop;

    //En AudioSource skapas som gör att musiken hörs. Att ha ett AudioClip men ingen AudioSource är som att ha en kassettspelare och en kasett, men ingen högtalare.
    //"[HideInInspector]" är till för att gömma AudioSource:en i Unity så att man inte kan se den. Den är lite onödig att ha där. 
    [HideInInspector]
    public AudioSource source;
}
