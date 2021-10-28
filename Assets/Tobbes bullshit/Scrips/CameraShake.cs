using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
  // Skrivet av markus

    // Value för player hit

    public Vector2 amplitude; // hur kraftig skakningen är

    public Vector2 frenquency; // hur mycket eller ofta det ska hända

    Vector2 time; // har med hur ofta det ska hända

    public bool shouldShake; // borde den skaka


    // Value för Enemy hit

    public Vector2 amp;

    public Vector2 fre;

    Vector2 ti;

    public bool sS;



    // Update is called once per frame
    void Update()
    {
        time.x += Time.deltaTime * frenquency.x;
        time.y += Time.deltaTime * frenquency.y;

        
        time.x += Time.deltaTime * fre.x;
        time.y += Time.deltaTime * fre.y;



        // Ändra så att den händer när spelaren blir träffad
        /*if (Player hit)
        {
        PlayerShake()
        }


        if (Enemy hit)

        {
        EnemyShake()
        }
       */
    }
    void PlayerShake()
    {
        Vector3 localPos = transform.localPosition;
        if (shouldShake)
        {
            localPos = new Vector3(Mathf.Sin(time.x) * amplitude.x, Mathf.Sin(time.y) * amplitude.y, 0);
        }
        else
        {
            localPos = Vector3.zero;
        }
    }
    void EnemyShake()
    {
        Vector3 localPos = transform.localPosition;
        if (sS)
        {
            localPos = new Vector3(Mathf.Sin(ti.x) * amp.x, Mathf.Sin(ti.y) * amp.y, 0);
        }
        else
        {
            transform.localPosition = localPos;
        }
    }
}
