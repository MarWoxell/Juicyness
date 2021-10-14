using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Bra cod som ska sparas


    public int score = 0;
    public Rigidbody rb;
    public Text text;



    public void Start()
    {

    }

    public void Update()
    {
        // Beh�ver �ndras f�r att reagera n�r fiender d�r


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.transform.position = rb.transform.position + new Vector3(0, 1, 0);
            score += 1;
            text.text = "" + score;
        }
    }

    // Ska h�nda n�r spelaren d�r

    public void SaveScore()
    {

        PlayerPrefs.SetInt("Score", score);
        print("Sparning");
    }


    //Ska h�nda i death screenen 
    public void LoadScore()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        print("Ladningfunkion");
        text.text = "" + score;
    }


}
