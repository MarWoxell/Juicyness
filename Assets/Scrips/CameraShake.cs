using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
  // Skrivet av markus


    public Vector2 amplitude; // hur kraftig skakningen �r

    public Vector2 frenquency; // hur mycket eller ofta det ska h�nda

    Vector2 time; // har med hur ofta det ska h�nda

    public bool shouldShake; // borde den skaka




    // Update is called once per frame
    void Update()
    {
        Vector3 localPos = transform.localPosition;
        time.x += Time.deltaTime * frenquency.x;
        time.y += Time.deltaTime * frenquency.y;



        if (shouldShake)
        {
            localPos = new Vector3(Mathf.Sin(time.x) * amplitude.x, Mathf.Sin(time.y) * amplitude.y, 0);
        }
        else
        {
            localPos = Vector3.zero;
        }
        transform.localPosition = localPos;


    }
}
