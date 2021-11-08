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

    public GameObject Camera;

    // Update is called once per frame
    void Update()
    {
        time.x += Time.deltaTime * frenquency.x;
        time.y += Time.deltaTime * frenquency.y;

        
        ti.x += Time.deltaTime * fre.x;
        ti.y += Time.deltaTime * fre.y;

        
       
    }
    public void PlayerShake()
    {
        if (shouldShake)
        {
            Camera.transform.localPosition = new Vector3(Mathf.Sin(time.x) * amplitude.x, Mathf.Sin(time.y) * amplitude.y, 0);
            Debug.Log("Yeet");

            Invoke("ResetCamera", 0.1f);
        }

    }
    public void EnemyShake()
    {
        if (sS)
        {
            Camera.transform.localPosition = new Vector3(Mathf.Sin(ti.x) * amp.x, Mathf.Sin(ti.y) * amp.y, 0);
            Debug.Log("Bonk");

            Invoke("ResetCamera", 0.1f);
        }
    }

    public void ResetCamera()
    {
        Camera.transform.localPosition = Vector3.zero;
    }
}
