using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //"FindObjectOfType<AudioManager>().Play("bla bla");" och allt med animation skrivet av Theo
    public Animator animator;

    // skrivet av Markus

    // Options menu
    public GameObject optionsMenu;

    //bool options = false;

    // Pause menu
    public GameObject pauseMenu;
    bool pause = false;


    //-----------//Ska lägga dit death scene saker senare efter man kan dö
    public GameObject deathMenu;
    bool death = false;

    // Start av scenen
    public void Start()
    {
        FindObjectOfType<AudioManager>().Play("Start Menu Music");

        pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;

        optionsMenu.SetActive(false);
        

        deathMenu.SetActive(false);
        death = false;

    }


    public void Dead()
    {
        // Invoke gör att functionen har en delay och siffran är hur lång delayen är
        Invoke("ReallyDead", 2);

        FindObjectOfType<AudioManager>().Mute("Gameplay Music");
        FindObjectOfType<AudioManager>().Play("Player Death");
    }

    public void ReallyDead()
    {
        deathMenu.SetActive(true);
        death = true;
        Time.timeScale = 0;
        FindObjectOfType<AudioManager>().Play("Death Music");
    }

    // Pause Menu knapp

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == false)
            {
                pause = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                FindObjectOfType<AudioManager>().Mute("Gameplay Music");
                FindObjectOfType<AudioManager>().UnMute("Pause Music");
            }
            else
            {
                pause = false;
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                FindObjectOfType<AudioManager>().UnMute("Gameplay Music");
                FindObjectOfType<AudioManager>().Mute("Pause Music");
            }

        }

        if (death == true)
        {
            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Dead();
        }
    }

    public void resume()
    {
        pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().UnMute("Gameplay Music");
        FindObjectOfType<AudioManager>().Mute("Pause Music");
    }



    // Byte av scener med knapp

    public void start()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void goBack()
    {
        SceneManager.LoadScene("MenuScene");
    }


    // Options Menu knappar. Inte klart och idéen blev borttagen

    //---------------------------//
    public void settings()
    {
        optionsMenu.SetActive(true);
        //options = true;
    }
    public void editied()
    {
        optionsMenu.SetActive(false);
        //options = false;
    }


    //------------------------------//


    // Quit knapp

    public void Quit()
    {
        Application.Quit();
    }

}
