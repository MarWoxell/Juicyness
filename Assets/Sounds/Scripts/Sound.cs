//Anv�nder UnityEngine.Audio. En hel del ljud modifieringar finns i detta namnutrymme.
using UnityEngine.Audio;
using UnityEngine;

//N�r vi tog bort "MonoBehaviour", f�r att g�ra klassen custom, s� tog vi �ven bort f�rm�gan f�r scripten att kunna synas i inspectorn...
//...D�rf�r m�ste vi markera den som "System.Serializable" vilket g�r att den kan synas igen. (Om vi inte gjorde detta s� skulle array:en inte kunna synas).
[System.Serializable]
public class Sound
{
    //Theos programmering. En custom klass med en lista av ljud och hur ljuden beter sig. 

    //En public string som heter "namn". Den �r till f�r att kunna n�mna l�ter och ljud.
    public string name;

    //Ett public AudioClip som heter "clip". I den ska man kunna l�gga in sitt ljud man vill spela.
    public AudioClip clip;

    //Tv� public floats som heter "Volume" och "Pitch". De �r till f�r att kunna kontrollera volym och tonh�jd. 
    //"Range" till�ter dig att l�gga till ett minimum- och maximumtal p� din float s� att man inte kan h�ja det till o�ndligheten... 
    //...Den skapar ocks� en slider i unity som man kan anv�nda f�r att h�ja och s�nka "ljudet" i detta fall.
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    //En public bool som heter "mute". Den �r till f�r att kunna tysta vissa ljud. Den �r satt p� "falskt" f�r att jag inte vill ha vartenda ljud tystade. 
    // Den �r till f�r bara en sak. Pause musiken. Testa att pausa i spelet s� kommer du fatta. 
    public bool mute = false;

    //En public bool som heter "loop". Den �r till f�r att kunna loop:a l�tar. 
    public bool loop;

    //En AudioSource skapas som g�r att musiken h�rs. Att ha ett AudioClip men ingen AudioSource �r som att ha en kassettspelare och en kasett, men ingen h�gtalare.
    //"[HideInInspector]" �r till f�r att g�mma AudioSource:en i Unity s� att man inte kan se den. Den �r lite on�dig att ha d�r. 
    [HideInInspector]
    public AudioSource source;
}
