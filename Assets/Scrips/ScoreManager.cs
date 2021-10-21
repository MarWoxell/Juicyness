using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Skrivet av Markus

    // Po�ng v�rden
    public int score = 0;
    public int bestScore = 0;

    // ska bort
    public Rigidbody rb;

    // F�r spelscenen
    public Text currentScore;
    public Text highScore;


    // F�r death screen
    public Text finalScore;
    public Text bestFinalScore;




    public void Start()
    {
        score = 0;
        bestScore = PlayerPrefs.GetInt("Score", 0);
        highScore.text = "Highscore " + bestScore;
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            SaveScore();
            print("Kollat");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            bestScore = PlayerPrefs.GetInt("Score", 0);
            print("Ladningfunkion");
            finalScore.text = "Score " + score;
            bestFinalScore.text = "HighScore " + bestScore;
        }

        // Beh�ver �ndras f�r att reagera n�r fiender d�r

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.transform.position = rb.transform.position + new Vector3(0, 1, 0);
            score += 1;
            currentScore.text = "Score " + score;
        }
    }

    // Ska h�nda n�r spelaren d�r

    public void SaveScore()
    {   
            if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("Score", bestScore);
            currentScore.text = "Score " + score;
            print("Nytt Highscore");
        }
        
       
    }


    //Ska h�nda i death screenen 
    public void LoadScore()
    {
      
    }


}
