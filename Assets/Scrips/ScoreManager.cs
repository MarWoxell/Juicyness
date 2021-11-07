using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Skrivet av Markus

    // Poäng värden
    public float score = 0;
    public float bestScore = 0;

    // ska bort
    public Rigidbody rb;

    // För spelscenen
    public Text currentScore;
    public Text highScore;


    // För death screen
    public Text finalScore;
    public Text bestFinalScore;



    // Start av scenen
    public void Start()
    {
        score = 0;
        bestScore = PlayerPrefs.GetFloat("Score", 0);
        highScore.text = "Highscore " + bestScore;
    }

    // För att testa saker

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

    // Ska hända när spelaren dör

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


    //Ska hända i death screenen 
    public void LoadScore()
    {
      
    }

    // ger poäng när spelaren blir träffad
    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == ("Enemy"))
        score += 0.25f;
    }



}
