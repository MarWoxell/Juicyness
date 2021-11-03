using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Skrivet av Markus

    // Po�ng v�rden
    public float score = 0;
    public float bestScore = 0;

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
        bestScore = PlayerPrefs.GetFloat("Score", 0);
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
            bestScore = PlayerPrefs.GetFloat("Score", 0);
            print("Ladningfunkion");
            finalScore.text = "Score " + score;
            bestFinalScore.text = "HighScore " + bestScore;
        }

        
        // Updaterar ens score hela tiden
        currentScore.text = "Score " + score;
        
    }

    // Ska h�nda n�r spelaren d�r

    public void SaveScore()
    {   
            if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetFloat("Score", bestScore);
            currentScore.text = "Score " + score;
            print("Nytt Highscore");
        }
        
       
    }


    //Ska h�nda i death screenen 
    public void LoadScore()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == ("Enemy"))
        score += 0.25f;
    }



}
